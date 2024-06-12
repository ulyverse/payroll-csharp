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
    public partial class DashboardForm : Form
    {
        private Employee _adminEmployee;
        private List<EmployeeDisplay>? _employees;
        private BindingSource employeeBindingSource = new BindingSource();
        private BindingSource payrollBindingSource = new BindingSource();

        public DashboardForm(Employee adminEmployee)
        {
            _adminEmployee = adminEmployee;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            PopulateEmployeesDGV();
            FormatEmployeesDGV();
            PopulateDepartmentListbox();
            PopulatePayrollDGV();
            FormatPayrollDGV();
        }

        private void FormatPayrollDGV()
        {
            dgvPayroll.Columns[0].Visible = false;
            dgvPayroll.Columns[1].HeaderText = "Start Date";
            dgvPayroll.Columns[2].HeaderText = "Stop Date";
            dgvPayroll.Columns[3].HeaderText = "Detailed Deductions";
        }

        private void FormatEmployeesDGV()
        {
            dgvEmployees.Columns[2].DefaultCellStyle.Format = "d";

            dgvEmployees.Columns[6].HeaderText = "Cash Adv";
            dgvEmployees.Columns[0].Visible = false;
            dgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEmployees.Columns[4].Width = 130;
            int[] colNumbers = new int[] { 5, 6, 7, 8, 9, 10 };
            foreach (int colNumber in colNumbers)
            {
                dgvEmployees.Columns[colNumber].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvEmployees.Columns[colNumber].Width = 110;
                dgvEmployees.Columns[colNumber].DefaultCellStyle.Format = "N2";
            }
        }

        private void PopulateDepartmentListbox()
        {
            listDepartments.DataSource = DepartmentData.GetAll();
            listDepartments.DisplayMember = "Name";
            listDepartments.ValueMember = "ID";
        }

        private void PopulateEmployeesDGV()
        {
            var employeeList = EmployeeData.GetAllDetailed();
            var employeeListDisplay = employeeList.Select(x => new EmployeeDisplay(x)).ToList();
            _employees = employeeListDisplay;
            employeeBindingSource.DataSource = employeeListDisplay;

            dgvEmployees.DataSource = employeeBindingSource;
        }

        private void PopulatePayrollDGV()
        {
            var payrollList = PayrollData.GetAll();
            if (payrollList.Count == 0)
                payrollBindingSource.DataSource = payrollList;
            else
                payrollBindingSource.DataSource = payrollList.OrderByDescending(x => x.ID);

            dgvPayroll.DataSource = payrollBindingSource;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            OpenEmployeeForm();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvEmployees.SelectedCells[0].RowIndex;
            int id = (int)dgvEmployees.Rows[rowIdx].Cells[0].Value;
            var employee = EmployeeData.FindById(id);
            OpenEmployeeForm(employee);
        }

        private void OpenEmployeeForm(Employee? emp = null)
        {
            var employeeForm = new EmployeeForm(emp);
            var result = employeeForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                PopulateEmployeesDGV();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBoxPrompt.Delete() == DialogResult.Yes)
            {
                int rowIdx = dgvEmployees.SelectedCells[0].RowIndex;
                int id = (int)dgvEmployees.Rows[rowIdx].Cells[0].Value;
                EmployeeData.Delete(id);
                PopulateEmployeesDGV();
            }

        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            int rowIdx = dgvEmployees.SelectedCells[0].RowIndex;
            int id = (int)dgvEmployees.Rows[rowIdx].Cells[0].Value;
            Employee? employee = EmployeeData.FindById(id);
            if (employee == null)
                MessageBoxPrompt.ShowInfo("Employee not found!");
            else if (new EditBalance(employee).ShowDialog() == DialogResult.OK)
            {
                PopulateEmployeesDGV();
            }
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text.Trim();

            if (departmentName == "")
            {
                MessageBoxPrompt.ShowInfo("Please input in the department name text box");
                return;
            }

            DialogResult result = MessageBoxPrompt.Save();
            if (result == DialogResult.Yes)
            {
                Department department = new Department() { Name = departmentName };
                DepartmentData.Insert(department);
                PopulateDepartmentListbox();
                txtDepartmentName.Text = "";
            }
            else if (result == DialogResult.No)
                txtDepartmentName.Text = "";
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            object? value = listDepartments.SelectedValue;
            if (value == null)
            {
                MessageBoxPrompt.ShowInfo("Department Not Found!");
                return;
            }
            else if (MessageBoxPrompt.Delete() == DialogResult.Yes)
            {
                int id = (int)value;
                DepartmentData.Delete(id);
                PopulateDepartmentListbox();
            }
        }

        private void btnCreatePayroll_Click(object sender, EventArgs e)
        {
            if (new CreatePayrollForm().ShowDialog() == DialogResult.OK)
            {
                PopulateEmployeesDGV();
                PopulatePayrollDGV();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridVeiw();
        }
        private void FilterDataGridVeiw()
        {
            var filteredList = _employees;
            string name = txtName.Text.Trim();
            if (name.Count() < 3)
            {
                employeeBindingSource.DataSource = _employees;
            }
            else
            {
                if (name != "")
                    filteredList = filteredList.Where(x => x.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)).ToList();
                employeeBindingSource.DataSource = filteredList;
            }
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.MdiParent = MdiParent;
            loginForm.Show();
        }

        private void dgvPayroll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIdx = e.RowIndex;

            if (rowIdx == -1) return;

            int payrollId = (int)dgvPayroll.Rows[rowIdx].Cells[0].Value;
            Payroll payroll = PayrollData.GetDetailed(payrollId);

            new ViewPayrollDetailed(payroll).Show();
        }

    }
}
