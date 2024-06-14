using PayrollLibrary;
using PayrollLibrary.Data_Access;
using PayrollLibrary.Model;
using PayrollLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGUI
{
    public partial class PayrollForm : Form
    {
        private Payroll _payroll;
        private List<Employee> _employees;
        private BindingList<PayrollEmployeeDisplay> _employeeDisplayList;
        private bool isCreatingPayroll = false;
        public PayrollForm(Payroll payroll)
        {
            _payroll = payroll;
            InitializeComponent();
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = $"Start: {_payroll.StartDate}";
            lblEndDate.Text = $"End: {_payroll.EndDate}";
            checkDetailedDeduction.Checked = _payroll.DetailedDeduction;
            _employees = EmployeeData.GetAll();
            listEmployees.DataSource = _employees;
            listEmployees.DisplayMember = "FullName";
            listEmployees.ValueMember = "ID";

            _employeeDisplayList = new BindingList<PayrollEmployeeDisplay>();
            dgvPayrollEmployees.DataSource = _employeeDisplayList;
            dgvPayrollEmployees.Columns[0].Visible = false;
            dgvPayrollEmployees.Columns[4].HeaderText = "Normal Hours";
            dgvPayrollEmployees.Columns[6].HeaderText = "Gross Pay";
            dgvPayrollEmployees.Columns[10].HeaderText = "CA Amount";
            dgvPayrollEmployees.Columns[12].HeaderText = "Total Deductions";
            dgvPayrollEmployees.Columns[13].HeaderText = "Net Pay";
            dgvPayrollEmployees.Columns[14].HeaderText = "Cash Advance";
            dgvPayrollEmployees.Columns[15].HeaderText = "Balance";
        }

        private void btnAddToPayroll_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)listEmployees.SelectedItem;

            if (emp == null) return;
            emp.Department = DepartmentData.FindById(emp.DepartmentID);
            var empDisplay = new PayrollEmployeeDisplay(emp, _payroll.DetailedDeduction);
            empDisplay.Attendances = AttendanceController.GetAttendances(_payroll.StartDate, _payroll.EndDate);
            var form = new AttendanceForm(empDisplay);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                _employeeDisplayList.Add(form._employee);
                _employees.Remove(emp);
                listEmployees.DataSource = null;
                listEmployees.DataSource = _employees;
                listEmployees.DisplayMember = "FullName";
                listEmployees.ValueMember = "ID";
            }

        }

        private void PayrollForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isCreatingPayroll)
            {
                if (MessageBoxPrompt.Exit() == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string name = txtSearch.Text.Trim();

            if (name == "")
            {
                listEmployees.DataSource = _employees;
            }
            else
            {
                listEmployees.DataSource = _employees.Where(x => x.FullName.Contains(name, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
        }

        private void dgvPayrollEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            OpenAttendanceForm();
        }

        private void OpenAttendanceForm()
        {
            int idx = dgvPayrollEmployees.SelectedCells[0].RowIndex;
            PayrollEmployeeDisplay item = (PayrollEmployeeDisplay)dgvPayrollEmployees.Rows[idx].DataBoundItem;

            if (item != null)
            {
                var form = new AttendanceForm(item).ShowDialog();
                dgvPayrollEmployees.Refresh();
            }
        }

        private void btnCreatePayroll_Click(object sender, EventArgs e)
        {
            if (dgvPayrollEmployees.Rows.Count == 0)
                MessageBoxPrompt.ShowInfo("There must be atleast one employee in order to create the payroll");
            else if (MessageBoxPrompt.Save("Do you want to create payroll?") == DialogResult.Yes)
            {
                PayrollData.Insert(_payroll);
                int? payrollID = PayrollData.GetLastId();
                foreach (DataGridViewRow row in dgvPayrollEmployees.Rows)
                {
                    PayrollEmployeeDisplay item = (PayrollEmployeeDisplay)row.DataBoundItem;

                    PayrollEmployee payrollEmployee = new PayrollEmployee();
                    payrollEmployee.EmployeeID = item.EmployeeID;
                    if (payrollID.HasValue)
                        payrollEmployee.PayrollID = payrollID.Value;
                    payrollEmployee.CurrentNormalHours = item.NormalHours;
                    payrollEmployee.CurrentOvertimeHours = item.Overtime;
                    payrollEmployee.CurrentSnack = item.Snack;
                    payrollEmployee.CurrentCashAdvanceAmountToPay = item.CashAdvanceAmountToPay;
                    payrollEmployee.CurrentCashAdvance = item.PreviousCashAdvance;
                    payrollEmployee.CurrentSSS = item.SSS;
                    payrollEmployee.CurrentPagIbig = item.PagIbig;
                    payrollEmployee.CurrentPhilHealth = item.PhilHealth;

                    Employee employee = EmployeeData.FindById(item.EmployeeID);
                    employee.Snack = 0;
                    employee.CashAdvance = item.NextCashAdvance;

                    EmployeeData.Update(employee);
                    PayrollEmployeeData.Insert(payrollEmployee);
                }
                DialogResult = DialogResult.OK;
                isCreatingPayroll = true;
                Close();
            }
        }
    }
}
