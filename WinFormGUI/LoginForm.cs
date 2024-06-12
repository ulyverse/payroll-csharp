using PayrollLibrary;
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
using WinFormGUI;

namespace WinFormGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBoxPrompt.ShowInfo("Please input both username and password");
                return;
            }

            var emp = EmployeeData.Login(username, password);

            if (emp == null)
                MessageBoxPrompt.ShowInfo("Incorrect Credentials");
            else
            {
                if (emp.RoleID == 2) //Administrator
                {
                    this.ChangeForm(new DashboardForm(emp));
                }
                else
                {
                    MessageBox.Show("cool!");
                }
            }
        }

        private void KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Login();
        }
    }
}
