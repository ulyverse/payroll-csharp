using PayrollLibrary.Data_Access;
using PayrollLibrary.Model;
using PayrollLibrary.PayrollSpreadsheet;
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
    public partial class ViewPayrollDetailed : Form
    {
        private Payroll _payroll;
        private List<PayrollEmployeeDisplay> payrollEmployeeDisplays;
        public ViewPayrollDetailed(Payroll payroll)
        {
            InitializeComponent();
            _payroll = payroll;
        }

        private void LoadPayrollEmployeeDisplayList()
        {
            List<PayrollEmployeeDisplay> payrollEmployeeDisplays = new List<PayrollEmployeeDisplay>();
            foreach (var payrollEmployee in _payroll.PayrollEmployees)
            {
                payrollEmployeeDisplays.Add(new PayrollEmployeeDisplay(payrollEmployee));
            }
            this.payrollEmployeeDisplays = payrollEmployeeDisplays;
        }

        private void ViewPayrollDetailed_Load(object sender, EventArgs e)
        {
            LoadPayrollEmployeeDisplayList();

            dgvPayrollEmployees.DataSource = payrollEmployeeDisplays;

            dgvPayrollEmployees.Columns[0].Visible = false;
            dgvPayrollEmployees.Columns[4].HeaderText = "Normal Hours";
            dgvPayrollEmployees.Columns[6].HeaderText = "Gross Pay";
            dgvPayrollEmployees.Columns[10].HeaderText = "Cash Adv Amount";
            dgvPayrollEmployees.Columns[12].HeaderText = "Total Deductions";
            dgvPayrollEmployees.Columns[13].HeaderText = "Net Pay";
            dgvPayrollEmployees.Columns[14].HeaderText = "Cash Advance";
            dgvPayrollEmployees.Columns[15].HeaderText = "Balance";
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearchName.Text.Trim();
            if (name.Length < 3)
            {
                dgvPayrollEmployees.DataSource = payrollEmployeeDisplays;
            }
            else
            {
                dgvPayrollEmployees.DataSource = payrollEmployeeDisplays.Where(x => x.Name.Contains(name)).ToList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (MessageBoxPrompt.YesNoPrompt("This might take a while to process, Do you want to proceed?", "Export To Excel") == DialogResult.Yes)
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string templatePath = Path.Combine(currentDirectory, "template.xlsx");
                string jsonPath = Path.Combine(currentDirectory, "template.json");
                var excelPayroll = new ExcelPayroll(templatePath, jsonPath);

                // these don't belong here....
                char[] targetColumn = { 'A', 'F' };
                int incrementValue = 29;
                int targetRow = 1;
                //

                excelPayroll.CreateFolder($"{_payroll.StartDate:MMMM dd}-{_payroll.EndDate:MMMM dd} ({_payroll.ID})");
                bool isOdd = false;
                foreach (PayrollEmployeeDisplay payrollDisplay in payrollEmployeeDisplays)
                {
                    string targetCell = $"{targetColumn[isOdd == true ? 1 : 0]}{targetRow}";//
                    if (isOdd)
                        targetRow += incrementValue;//
                    isOdd = !isOdd;

                    excelPayroll.FillWorksheet(_payroll, payrollDisplay);
                    excelPayroll.CopyPasteTemplate(targetCell);
                }

                excelPayroll.CreatePayroll($"{_payroll.StartDate:MMMM dd}-{_payroll.EndDate:MMMM dd}");
                excelPayroll.Dispose();
                MessageBoxPrompt.ShowInfo("Exporting Done!");

            }
        }
    }
}
