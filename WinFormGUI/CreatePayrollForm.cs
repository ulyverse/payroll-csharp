using PayrollLibrary;
using PayrollLibrary.Model;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormGUI
{
    public partial class CreatePayrollForm : Form
    {
        public CreatePayrollForm()
        {
            InitializeComponent();
        }

        private void CreatePayrollForm_Load(object sender, EventArgs e)
        {
            dateStartDate.Value = DateTime.Now.AddDays(-6);
        }

        private void btnCreatePayroll_Click(object sender, EventArgs e)
        {
            var startDate = DateOnly.FromDateTime(dateStartDate.Value);
            var endDate = DateOnly.FromDateTime(dateEndDate.Value);
            if (endDate.CompareTo(startDate) == -1)
            {
                MessageBoxPrompt.ShowInfo("Start date cannot be later than End date");
            }
            else
            {
                Payroll payroll = new Payroll()
                {
                    StartDate = startDate,
                    EndDate = endDate,
                    DetailedDeduction = checkDetailedDeduction.Checked
                };

                this.Hide();
                DialogResult result = new PayrollForm(payroll).ShowDialog();

                if (result == DialogResult.OK || result == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}
