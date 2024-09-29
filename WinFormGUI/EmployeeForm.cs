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

namespace WinFormGUI
{
    public partial class EmployeeForm : Form
    {
        private bool editMode;
        private Employee currentEmployee;
        private bool isSaveAndClose;
        public EmployeeForm(Employee? employee = null)
        {
            editMode = employee == null ? false : true;
            currentEmployee = employee;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            decimal salary = 0;
            decimal pagIbig = 0;
            decimal sss = 0;
            decimal philHealth = 0;
            string textPassword = txtPassword.Text.Trim();
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
            {
                MessageBoxPrompt.ShowInfo("Please input all the required field.");
            }
            else if (!decimal.TryParse(txtSalary.Text.Trim(), out salary) ||
                !decimal.TryParse(txtPagIbig.Text.Trim(), out pagIbig) ||
                !decimal.TryParse(txtSSS.Text.Trim(), out sss) ||
                !decimal.TryParse(txtPhilHealth.Text.Trim(), out philHealth)
                )
            {
                MessageBoxPrompt.ShowInfo("These fields can only accept a number {salary, pagibig, sss, philhealth}");
            }
            else
            {
                if (currentEmployee == null)
                    currentEmployee = new Employee() { IsActive = true };


                currentEmployee.FirstName = txtFirstName.Text;
                currentEmployee.LastName = txtLastName.Text;
                currentEmployee.Birthdate = DateOnly.FromDateTime(dateBirthdate.Value);
                currentEmployee.DepartmentID = (int)cmbDepartment.SelectedValue;
                currentEmployee.RoleID = (int)cmbRoles.SelectedValue;

                currentEmployee.Username = txtUsername.Text.Trim();
                currentEmployee.Password = textPassword == currentEmployee.Password ? currentEmployee.Password : Helper.HashToMd5(textPassword);

                currentEmployee.Salary = salary;
                currentEmployee.PagIbig = pagIbig;
                currentEmployee.SSS = sss;
                currentEmployee.PhilHealth = philHealth;


                var result = MessageBoxPrompt.Save();

                if (result == DialogResult.Cancel)
                    return;

                if (result == DialogResult.Yes)
                {
                    if (editMode)
                        EmployeeData.Update(currentEmployee);
                    else
                        EmployeeData.Insert(currentEmployee);

                    DialogResult = DialogResult.Yes;
                }
                isSaveAndClose = true;
                Close();
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtFirstName;
            var departments = DepartmentData.GetAll();
            var roles = RoleData.GetAll();
            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "ID";
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Name";
            cmbRoles.ValueMember = "ID";


            if (editMode)
            {
                this.Text = "Edit Employee Form";
                btnAddEdit.Text = "Edit";

                txtFirstName.Text = currentEmployee.FirstName;
                txtLastName.Text = currentEmployee.LastName;
                dateBirthdate.Value = currentEmployee.Birthdate.ToDateTime(TimeOnly.MinValue);
                if (currentEmployee.DepartmentID != null)
                    cmbDepartment.SelectedValue = currentEmployee.DepartmentID;
                cmbRoles.SelectedValue = currentEmployee.RoleID;
                txtUsername.Text = currentEmployee.Username;
                txtPassword.Text = currentEmployee.Password;
                txtSalary.Text = currentEmployee.Salary.ToString();
                txtSSS.Text = currentEmployee.SSS.ToString();
                txtPagIbig.Text = currentEmployee.PagIbig.ToString();
                txtPhilHealth.Text = currentEmployee.PhilHealth.ToString();
            }

        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaveAndClose)
            {
                if (MessageBoxPrompt.Exit() == DialogResult.No)
                    e.Cancel = true;
            }

        }
    }
}
