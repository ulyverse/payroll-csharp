using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollLibrary;

namespace Payroll_System_Tentative
{
    public partial class TestForm : Form
    {
        private AttendanceController paySystem;
        private double ratePerHour;
        public TestForm()
        {
            InitializeComponent();
            paySystem = new AttendanceController();

        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            ratePerHour = 50;

            lblRate.Text += $" {ratePerHour}";
        }

        private void btnCalculateGrossPay_Click(object sender, EventArgs e)
        { 

            var morningHours = paySystem.GetHoursSpent(
                paySystem.ParseTime(monTimeinMorning.Text), paySystem.ParseTime(monTimeoutMorning.Text));

            var afternoonHours = paySystem.GetHoursSpent(
                paySystem.ParseTime(monTimeinAfterNoon.Text), paySystem.ParseTime(monTimeoutAfterNoon.Text));

            var overtimeHours = paySystem.GetHoursSpent(
                paySystem.ParseTime(monTimeinOT.Text), paySystem.ParseTime (monTimeoutOT.Text));

            var totalHours = paySystem.GetTotalHours(morningHours, afternoonHours);

            var grossPay = paySystem.GetGrossPay(totalHours, overtimeHours, 1, ratePerHour);

            lblGrossPay.Text = $"Gross Pay: {grossPay}";
            lblTotalHours.Text = $"Total Hours: {totalHours}";
            lblOvertime.Text = $"Overtime: {overtimeHours}";

        }
    }
}
