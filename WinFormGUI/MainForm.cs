using PayrollLibrary;
using PayrollLibrary.Data_Access;
using PayrollLibrary.Model;

namespace WinFormGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //new CreatePayrollForm().ShowDialog();

            //var dashboard = new DashboardForm(EmployeeData.GetById(1));
            //dashboard.MdiParent = this;
            //dashboard.Show();

            var loginForm = new LoginForm();
            loginForm.MdiParent = this;
            loginForm.Show();
        }
    }
}
