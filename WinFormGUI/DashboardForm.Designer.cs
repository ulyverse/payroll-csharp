namespace WinFormGUI
{
    partial class DashboardForm
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
            pageEmployee = new TabPage();
            mainPanel = new Panel();
            dgvEmployees = new DataGridView();
            topPanel = new Panel();
            lblFirstname = new Label();
            lblSearch = new Label();
            txtName = new TextBox();
            bottomPanel = new Panel();
            btnAddBalance = new Button();
            btnAddEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            pagePayroll = new TabPage();
            dgvPayroll = new DataGridView();
            btnCreatePayroll = new Button();
            tabControlDashboard = new TabControl();
            pageDepartments = new TabPage();
            lblDepartmentName = new Label();
            txtDepartmentName = new TextBox();
            btnRemoveDepartment = new Button();
            btnAddDepartment = new Button();
            listDepartments = new ListBox();
            pageEmployee.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            topPanel.SuspendLayout();
            bottomPanel.SuspendLayout();
            pagePayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).BeginInit();
            tabControlDashboard.SuspendLayout();
            pageDepartments.SuspendLayout();
            SuspendLayout();
            // 
            // pageEmployee
            // 
            pageEmployee.Controls.Add(mainPanel);
            pageEmployee.Controls.Add(topPanel);
            pageEmployee.Controls.Add(bottomPanel);
            pageEmployee.Location = new Point(4, 27);
            pageEmployee.Name = "pageEmployee";
            pageEmployee.Padding = new Padding(3);
            pageEmployee.Size = new Size(1376, 650);
            pageEmployee.TabIndex = 1;
            pageEmployee.Text = "Employees";
            pageEmployee.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(dgvEmployees);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(3, 38);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1370, 574);
            mainPanel.TabIndex = 6;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToOrderColumns = true;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1370, 574);
            dgvEmployees.TabIndex = 4;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblFirstname);
            topPanel.Controls.Add(lblSearch);
            topPanel.Controls.Add(txtName);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(3, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1370, 35);
            topPanel.TabIndex = 5;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(136, 8);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(62, 18);
            lblFirstname.TabIndex = 2;
            lblFirstname.Text = "Name:";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(15, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 18);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "SEARCH";
            // 
            // txtName
            // 
            txtName.Location = new Point(204, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(btnAddBalance);
            bottomPanel.Controls.Add(btnAddEmployee);
            bottomPanel.Controls.Add(btnEditEmployee);
            bottomPanel.Controls.Add(btnDeleteEmployee);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(3, 612);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1370, 35);
            bottomPanel.TabIndex = 5;
            // 
            // btnAddBalance
            // 
            btnAddBalance.Font = new Font("Verdana", 10F);
            btnAddBalance.Location = new Point(196, 2);
            btnAddBalance.Name = "btnAddBalance";
            btnAddBalance.Size = new Size(229, 31);
            btnAddBalance.TabIndex = 1;
            btnAddBalance.Text = "Edit Balance";
            btnAddBalance.UseVisualStyleBackColor = true;
            btnAddBalance.Click += btnAddBalance_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Verdana", 10F);
            btnAddEmployee.Location = new Point(446, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(229, 31);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.Text = "Add New Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Font = new Font("Verdana", 10F);
            btnEditEmployee.Location = new Point(696, 2);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(229, 31);
            btnEditEmployee.TabIndex = 3;
            btnEditEmployee.Text = "Edit Selected Employee";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Font = new Font("Verdana", 10F);
            btnDeleteEmployee.ForeColor = Color.Red;
            btnDeleteEmployee.Location = new Point(946, 2);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(229, 31);
            btnDeleteEmployee.TabIndex = 4;
            btnDeleteEmployee.Text = "Delete Selected Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // pagePayroll
            // 
            pagePayroll.Controls.Add(dgvPayroll);
            pagePayroll.Controls.Add(btnCreatePayroll);
            pagePayroll.Location = new Point(4, 27);
            pagePayroll.Name = "pagePayroll";
            pagePayroll.Padding = new Padding(3);
            pagePayroll.Size = new Size(1376, 650);
            pagePayroll.TabIndex = 0;
            pagePayroll.Text = "Payroll";
            pagePayroll.UseVisualStyleBackColor = true;
            // 
            // dgvPayroll
            // 
            dgvPayroll.AllowUserToAddRows = false;
            dgvPayroll.AllowUserToDeleteRows = false;
            dgvPayroll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayroll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayroll.Location = new Point(20, 74);
            dgvPayroll.MultiSelect = false;
            dgvPayroll.Name = "dgvPayroll";
            dgvPayroll.ReadOnly = true;
            dgvPayroll.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayroll.Size = new Size(626, 541);
            dgvPayroll.TabIndex = 1;
            dgvPayroll.CellDoubleClick += dgvPayroll_CellDoubleClick;
            // 
            // btnCreatePayroll
            // 
            btnCreatePayroll.Location = new Point(20, 17);
            btnCreatePayroll.Name = "btnCreatePayroll";
            btnCreatePayroll.Size = new Size(201, 40);
            btnCreatePayroll.TabIndex = 0;
            btnCreatePayroll.Text = "Create Payroll";
            btnCreatePayroll.UseVisualStyleBackColor = true;
            btnCreatePayroll.Click += btnCreatePayroll_Click;
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(pagePayroll);
            tabControlDashboard.Controls.Add(pageEmployee);
            tabControlDashboard.Controls.Add(pageDepartments);
            tabControlDashboard.Dock = DockStyle.Fill;
            tabControlDashboard.Location = new Point(0, 0);
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(1384, 681);
            tabControlDashboard.TabIndex = 1;
            // 
            // pageDepartments
            // 
            pageDepartments.Controls.Add(lblDepartmentName);
            pageDepartments.Controls.Add(txtDepartmentName);
            pageDepartments.Controls.Add(btnRemoveDepartment);
            pageDepartments.Controls.Add(btnAddDepartment);
            pageDepartments.Controls.Add(listDepartments);
            pageDepartments.Location = new Point(4, 24);
            pageDepartments.Name = "pageDepartments";
            pageDepartments.Padding = new Padding(3);
            pageDepartments.Size = new Size(1376, 653);
            pageDepartments.TabIndex = 2;
            pageDepartments.Text = "Departments";
            pageDepartments.UseVisualStyleBackColor = true;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(262, 20);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(163, 18);
            lblDepartmentName.TabIndex = 4;
            lblDepartmentName.Text = "Department name:";
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(262, 41);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(161, 27);
            txtDepartmentName.TabIndex = 3;
            // 
            // btnRemoveDepartment
            // 
            btnRemoveDepartment.ForeColor = Color.Red;
            btnRemoveDepartment.Location = new Point(262, 193);
            btnRemoveDepartment.Name = "btnRemoveDepartment";
            btnRemoveDepartment.Size = new Size(161, 35);
            btnRemoveDepartment.TabIndex = 2;
            btnRemoveDepartment.Text = "Remove";
            btnRemoveDepartment.UseVisualStyleBackColor = true;
            btnRemoveDepartment.Click += btnRemoveDepartment_Click;
            // 
            // btnAddDepartment
            // 
            btnAddDepartment.Location = new Point(262, 152);
            btnAddDepartment.Name = "btnAddDepartment";
            btnAddDepartment.Size = new Size(161, 35);
            btnAddDepartment.TabIndex = 1;
            btnAddDepartment.Text = "Add";
            btnAddDepartment.UseVisualStyleBackColor = true;
            btnAddDepartment.Click += btnAddDepartment_Click;
            // 
            // listDepartments
            // 
            listDepartments.FormattingEnabled = true;
            listDepartments.ItemHeight = 18;
            listDepartments.Location = new Point(8, 6);
            listDepartments.Name = "listDepartments";
            listDepartments.Size = new Size(235, 220);
            listDepartments.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 681);
            Controls.Add(tabControlDashboard);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "DashboardForm";
            Text = "Dashboard Form";
            FormClosing += DashboardForm_FormClosing;
            Load += DashboardForm_Load;
            pageEmployee.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            bottomPanel.ResumeLayout(false);
            pagePayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayroll).EndInit();
            tabControlDashboard.ResumeLayout(false);
            pageDepartments.ResumeLayout(false);
            pageDepartments.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage pageEmployee;
        private TabPage pagePayroll;
        private TabControl tabControlDashboard;
        private Button btnDeleteEmployee;
        private Button btnEditEmployee;
        private Button btnAddEmployee;
        private DataGridView dgvEmployees;
        private Panel bottomPanel;
        private TabPage pageDepartments;
        private Button btnAddBalance;
        private Button btnRemoveDepartment;
        private Button btnAddDepartment;
        private ListBox listDepartments;
        private Label lblDepartmentName;
        private TextBox txtDepartmentName;
        private Button btnCreatePayroll;
        private Panel topPanel;
        private TextBox txtName;
        private Panel mainPanel;
        private Label lblFirstname;
        private Label lblSearch;
        private DataGridView dgvPayroll;
    }
}