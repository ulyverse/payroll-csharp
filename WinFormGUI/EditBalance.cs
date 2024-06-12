using PayrollLibrary.Data_Access;
using PayrollLibrary.Model;
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
    public partial class EditBalance : Form
    {
        private Employee _employee;
        private bool isSaving = false;
        public EditBalance(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (!decimal.TryParse(txtBalance.Text, out amount))
            {
                MessageBoxPrompt.ShowInfo("Please enter a valid amount number");
            }
            else if (amount < 0)
            {
                MessageBoxPrompt.ShowInfo("Amount cannot be negative.");
            }
            else if (MessageBoxPrompt.Save() == DialogResult.Yes)
            {
                if (rbtnCashAdvance.Checked)
                    _employee.CashAdvance += amount;
                else
                    _employee.Snack += amount;
                EmployeeData.Update(_employee);
                isSaving = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditBalance_Load(object sender, EventArgs e)
        {
            rbtnCashAdvance.Checked = true;
            lblEmployeeName.Text = _employee.FullName;
        }

        private void EditBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaving)
                if (MessageBoxPrompt.Exit() == DialogResult.No)
                    e.Cancel = true;
        }
    }
}
