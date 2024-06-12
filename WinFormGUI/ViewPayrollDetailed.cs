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
            dgvPayrollEmployees.Columns[6].HeaderText = "Gross Pay";
            dgvPayrollEmployees.Columns[10].HeaderText = "Cash Adv Amount";
            dgvPayrollEmployees.Columns[12].HeaderText = "Deductions";
            dgvPayrollEmployees.Columns[13].HeaderText = "Net Pay";
            dgvPayrollEmployees.Columns[14].HeaderText = "Cash Advance";
            dgvPayrollEmployees.Columns[15].HeaderText = "Balance";
            //dgvPayrollEmployees.Columns[4].Visible = false;
            //dgvPayrollEmployees.Columns[5].Visible = false;
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
    }
}
