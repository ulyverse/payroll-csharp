namespace WinFormGUI
{
    partial class PayrollForm
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
            mainPanel = new Panel();
            panelPayrolEmployee = new Panel();
            dgvPayrollEmployees = new DataGridView();
            buttonsPanel = new Panel();
            btnCreatePayroll = new Button();
            btnCancel = new Button();
            sidePanel = new Panel();
            grpEmployeeList = new GroupBox();
            lblSearch = new Label();
            listEmployees = new ListBox();
            btnAddToPayroll = new Button();
            txtSearch = new TextBox();
            grpPayrollInformation = new GroupBox();
            checkDetailedDeduction = new CheckBox();
            lblEndDate = new Label();
            lblStartDate = new Label();
            mainPanel.SuspendLayout();
            panelPayrolEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayrollEmployees).BeginInit();
            buttonsPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            grpEmployeeList.SuspendLayout();
            grpPayrollInformation.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panelPayrolEmployee);
            mainPanel.Controls.Add(buttonsPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(343, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1521, 681);
            mainPanel.TabIndex = 0;
            // 
            // panelPayrolEmployee
            // 
            panelPayrolEmployee.Controls.Add(dgvPayrollEmployees);
            panelPayrolEmployee.Dock = DockStyle.Fill;
            panelPayrolEmployee.Location = new Point(0, 0);
            panelPayrolEmployee.Name = "panelPayrolEmployee";
            panelPayrolEmployee.Padding = new Padding(20, 20, 20, 0);
            panelPayrolEmployee.Size = new Size(1521, 627);
            panelPayrolEmployee.TabIndex = 2;
            // 
            // dgvPayrollEmployees
            // 
            dgvPayrollEmployees.AllowUserToAddRows = false;
            dgvPayrollEmployees.AllowUserToDeleteRows = false;
            dgvPayrollEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayrollEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayrollEmployees.Dock = DockStyle.Fill;
            dgvPayrollEmployees.Location = new Point(20, 20);
            dgvPayrollEmployees.MultiSelect = false;
            dgvPayrollEmployees.Name = "dgvPayrollEmployees";
            dgvPayrollEmployees.ReadOnly = true;
            dgvPayrollEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayrollEmployees.Size = new Size(1481, 607);
            dgvPayrollEmployees.TabIndex = 0;
            dgvPayrollEmployees.CellDoubleClick += dgvPayrollEmployees_CellDoubleClick;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(btnCreatePayroll);
            buttonsPanel.Controls.Add(btnCancel);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 627);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(1521, 54);
            buttonsPanel.TabIndex = 1;
            // 
            // btnCreatePayroll
            // 
            btnCreatePayroll.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreatePayroll.ForeColor = SystemColors.ControlText;
            btnCreatePayroll.Location = new Point(1148, 9);
            btnCreatePayroll.Name = "btnCreatePayroll";
            btnCreatePayroll.Size = new Size(215, 35);
            btnCreatePayroll.TabIndex = 1;
            btnCreatePayroll.Text = "Create Payroll";
            btnCreatePayroll.UseVisualStyleBackColor = true;
            btnCreatePayroll.Click += btnCreatePayroll_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(1381, 9);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(grpEmployeeList);
            sidePanel.Controls.Add(grpPayrollInformation);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(10, 10, 0, 10);
            sidePanel.Size = new Size(343, 681);
            sidePanel.TabIndex = 1;
            // 
            // grpEmployeeList
            // 
            grpEmployeeList.Controls.Add(lblSearch);
            grpEmployeeList.Controls.Add(listEmployees);
            grpEmployeeList.Controls.Add(btnAddToPayroll);
            grpEmployeeList.Controls.Add(txtSearch);
            grpEmployeeList.Dock = DockStyle.Fill;
            grpEmployeeList.Location = new Point(10, 190);
            grpEmployeeList.Name = "grpEmployeeList";
            grpEmployeeList.Size = new Size(333, 481);
            grpEmployeeList.TabIndex = 1;
            grpEmployeeList.TabStop = false;
            grpEmployeeList.Text = "Employees";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(19, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(69, 18);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // listEmployees
            // 
            listEmployees.FormattingEnabled = true;
            listEmployees.ItemHeight = 18;
            listEmployees.Location = new Point(16, 96);
            listEmployees.Name = "listEmployees";
            listEmployees.Size = new Size(298, 364);
            listEmployees.TabIndex = 3;
            // 
            // btnAddToPayroll
            // 
            btnAddToPayroll.Location = new Point(207, 63);
            btnAddToPayroll.Name = "btnAddToPayroll";
            btnAddToPayroll.Size = new Size(107, 27);
            btnAddToPayroll.TabIndex = 2;
            btnAddToPayroll.Text = "Add";
            btnAddToPayroll.UseVisualStyleBackColor = true;
            btnAddToPayroll.Click += btnAddToPayroll_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // grpPayrollInformation
            // 
            grpPayrollInformation.Controls.Add(checkDetailedDeduction);
            grpPayrollInformation.Controls.Add(lblEndDate);
            grpPayrollInformation.Controls.Add(lblStartDate);
            grpPayrollInformation.Dock = DockStyle.Top;
            grpPayrollInformation.Location = new Point(10, 10);
            grpPayrollInformation.Name = "grpPayrollInformation";
            grpPayrollInformation.Size = new Size(333, 180);
            grpPayrollInformation.TabIndex = 0;
            grpPayrollInformation.TabStop = false;
            grpPayrollInformation.Text = "Payroll Configuration";
            // 
            // checkDetailedDeduction
            // 
            checkDetailedDeduction.AutoCheck = false;
            checkDetailedDeduction.AutoSize = true;
            checkDetailedDeduction.Location = new Point(19, 120);
            checkDetailedDeduction.Name = "checkDetailedDeduction";
            checkDetailedDeduction.Size = new Size(184, 22);
            checkDetailedDeduction.TabIndex = 2;
            checkDetailedDeduction.Text = "Detailed Deduction";
            checkDetailedDeduction.UseVisualStyleBackColor = true;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(29, 82);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(45, 18);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "End:";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(19, 40);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(55, 18);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start:";
            // 
            // PayrollForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1864, 681);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "PayrollForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll Form";
            FormClosing += PayrollForm_FormClosing;
            Load += PayrollForm_Load;
            mainPanel.ResumeLayout(false);
            panelPayrolEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayrollEmployees).EndInit();
            buttonsPanel.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            grpEmployeeList.ResumeLayout(false);
            grpEmployeeList.PerformLayout();
            grpPayrollInformation.ResumeLayout(false);
            grpPayrollInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel sidePanel;
        private GroupBox grpEmployeeList;
        private GroupBox grpPayrollInformation;
        private Label lblEndDate;
        private Label lblStartDate;
        private CheckBox checkDetailedDeduction;
        private Button btnAddToPayroll;
        private TextBox txtSearch;
        private DataGridView dgvPayrollEmployees;
        private ListBox listEmployees;
        private Panel buttonsPanel;
        private Button btnCancel;
        private Button btnCreatePayroll;
        private Panel panelPayrolEmployee;
        private Label lblSearch;
    }
}