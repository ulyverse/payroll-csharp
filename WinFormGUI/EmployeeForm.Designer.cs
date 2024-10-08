﻿namespace WinFormGUI
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblBirthdate = new Label();
            dateBirthdate = new DateTimePicker();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            cmbRoles = new ComboBox();
            lblRoles = new Label();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblSSS = new Label();
            txtSSS = new TextBox();
            lblPagIbig = new Label();
            txtPagIbig = new TextBox();
            lblPhilHealth = new Label();
            txtPhilHealth = new TextBox();
            btnAddEdit = new Button();
            btnCancel = new Button();
            grpEmployeeInformation = new GroupBox();
            grpSalary = new GroupBox();
            grpEmployeeInformation.SuspendLayout();
            grpSalary.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(33, 43);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(129, 25);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(168, 40);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(151, 32);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(168, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(151, 32);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(37, 86);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(125, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last name:";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.Location = new Point(47, 129);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(115, 25);
            lblBirthdate.TabIndex = 4;
            lblBirthdate.Text = "Birthdate:";
            // 
            // dateBirthdate
            // 
            dateBirthdate.Format = DateTimePickerFormat.Short;
            dateBirthdate.Location = new Point(168, 126);
            dateBirthdate.Name = "dateBirthdate";
            dateBirthdate.Size = new Size(151, 32);
            dateBirthdate.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(39, 258);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 25);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(168, 253);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(151, 32);
            txtUsername.TabIndex = 11;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(48, 301);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(168, 296);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(151, 32);
            txtPassword.TabIndex = 13;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(21, 172);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(141, 25);
            lblDepartment.TabIndex = 10;
            lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(168, 169);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 33);
            cmbDepartment.TabIndex = 7;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(168, 211);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(151, 33);
            cmbRoles.TabIndex = 9;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Location = new Point(87, 215);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(75, 25);
            lblRoles.TabIndex = 12;
            lblRoles.Text = "Roles:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(60, 57);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(86, 25);
            lblSalary.TabIndex = 14;
            lblSalary.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(149, 54);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(151, 32);
            txtSalary.TabIndex = 15;
            // 
            // lblSSS
            // 
            lblSSS.AutoSize = true;
            lblSSS.Location = new Point(80, 104);
            lblSSS.Name = "lblSSS";
            lblSSS.Size = new Size(63, 25);
            lblSSS.TabIndex = 16;
            lblSSS.Text = "SSS:";
            // 
            // txtSSS
            // 
            txtSSS.Location = new Point(149, 101);
            txtSSS.Name = "txtSSS";
            txtSSS.Size = new Size(151, 32);
            txtSSS.TabIndex = 17;
            // 
            // lblPagIbig
            // 
            lblPagIbig.AutoSize = true;
            lblPagIbig.Location = new Point(48, 151);
            lblPagIbig.Name = "lblPagIbig";
            lblPagIbig.Size = new Size(95, 25);
            lblPagIbig.TabIndex = 18;
            lblPagIbig.Text = "PagIbig:";
            // 
            // txtPagIbig
            // 
            txtPagIbig.Location = new Point(149, 148);
            txtPagIbig.Name = "txtPagIbig";
            txtPagIbig.Size = new Size(151, 32);
            txtPagIbig.TabIndex = 19;
            // 
            // lblPhilHealth
            // 
            lblPhilHealth.AutoSize = true;
            lblPhilHealth.Location = new Point(26, 198);
            lblPhilHealth.Name = "lblPhilHealth";
            lblPhilHealth.Size = new Size(124, 25);
            lblPhilHealth.TabIndex = 20;
            lblPhilHealth.Text = "PhilHealth:";
            // 
            // txtPhilHealth
            // 
            txtPhilHealth.Location = new Point(149, 195);
            txtPhilHealth.Name = "txtPhilHealth";
            txtPhilHealth.Size = new Size(151, 32);
            txtPhilHealth.TabIndex = 21;
            // 
            // btnAddEdit
            // 
            btnAddEdit.Location = new Point(419, 355);
            btnAddEdit.Name = "btnAddEdit";
            btnAddEdit.Size = new Size(151, 35);
            btnAddEdit.TabIndex = 22;
            btnAddEdit.Text = "Add";
            btnAddEdit.UseVisualStyleBackColor = true;
            btnAddEdit.Click += btnSubmitEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(595, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 35);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpEmployeeInformation
            // 
            grpEmployeeInformation.Controls.Add(txtFirstName);
            grpEmployeeInformation.Controls.Add(lblFirstName);
            grpEmployeeInformation.Controls.Add(lblLastName);
            grpEmployeeInformation.Controls.Add(txtLastName);
            grpEmployeeInformation.Controls.Add(lblBirthdate);
            grpEmployeeInformation.Controls.Add(dateBirthdate);
            grpEmployeeInformation.Controls.Add(lblUsername);
            grpEmployeeInformation.Controls.Add(txtUsername);
            grpEmployeeInformation.Controls.Add(lblPassword);
            grpEmployeeInformation.Controls.Add(txtPassword);
            grpEmployeeInformation.Controls.Add(cmbRoles);
            grpEmployeeInformation.Controls.Add(lblDepartment);
            grpEmployeeInformation.Controls.Add(lblRoles);
            grpEmployeeInformation.Controls.Add(cmbDepartment);
            grpEmployeeInformation.Location = new Point(52, 27);
            grpEmployeeInformation.Name = "grpEmployeeInformation";
            grpEmployeeInformation.Size = new Size(340, 363);
            grpEmployeeInformation.TabIndex = 24;
            grpEmployeeInformation.TabStop = false;
            grpEmployeeInformation.Text = "Employee Information";
            // 
            // grpSalary
            // 
            grpSalary.Controls.Add(txtSalary);
            grpSalary.Controls.Add(lblSalary);
            grpSalary.Controls.Add(txtPhilHealth);
            grpSalary.Controls.Add(lblSSS);
            grpSalary.Controls.Add(lblPhilHealth);
            grpSalary.Controls.Add(txtSSS);
            grpSalary.Controls.Add(txtPagIbig);
            grpSalary.Controls.Add(lblPagIbig);
            grpSalary.Location = new Point(419, 27);
            grpSalary.Name = "grpSalary";
            grpSalary.Size = new Size(327, 280);
            grpSalary.TabIndex = 25;
            grpSalary.TabStop = false;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 416);
            Controls.Add(btnCancel);
            Controls.Add(btnAddEdit);
            Controls.Add(grpEmployeeInformation);
            Controls.Add(grpSalary);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "EmployeeForm";
            Text = "Add Employee Form";
            FormClosing += EmployeeForm_FormClosing;
            Load += EmployeeForm_Load;
            grpEmployeeInformation.ResumeLayout(false);
            grpEmployeeInformation.PerformLayout();
            grpSalary.ResumeLayout(false);
            grpSalary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblBirthdate;
        private DateTimePicker dateBirthdate;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private ComboBox cmbRoles;
        private Label lblRoles;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblSSS;
        private TextBox txtSSS;
        private Label lblPagIbig;
        private TextBox txtPagIbig;
        private Label lblPhilHealth;
        private TextBox txtPhilHealth;
        private Button btnAddEdit;
        private Button btnCancel;
        private GroupBox grpEmployeeInformation;
        private GroupBox grpSalary;
    }
}