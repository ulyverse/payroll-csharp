namespace WinFormGUI
{
    partial class ViewPayrollDetailed
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
            dgvPayrollEmployees = new DataGridView();
            topPanel = new Panel();
            txtSearchName = new TextBox();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPayrollEmployees).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPayrollEmployees
            // 
            dgvPayrollEmployees.AllowUserToAddRows = false;
            dgvPayrollEmployees.AllowUserToDeleteRows = false;
            dgvPayrollEmployees.AllowUserToResizeRows = false;
            dgvPayrollEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayrollEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayrollEmployees.Dock = DockStyle.Fill;
            dgvPayrollEmployees.Location = new Point(0, 40);
            dgvPayrollEmployees.MultiSelect = false;
            dgvPayrollEmployees.Name = "dgvPayrollEmployees";
            dgvPayrollEmployees.ReadOnly = true;
            dgvPayrollEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayrollEmployees.Size = new Size(1784, 641);
            dgvPayrollEmployees.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(txtSearchName);
            topPanel.Controls.Add(lblName);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1784, 40);
            topPanel.TabIndex = 1;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(103, 7);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(223, 27);
            txtSearchName.TabIndex = 1;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // ViewPayrollDetailed
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1784, 681);
            Controls.Add(dgvPayrollEmployees);
            Controls.Add(topPanel);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "ViewPayrollDetailed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payroll";
            Load += ViewPayrollDetailed_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayrollEmployees).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPayrollEmployees;
        private Panel topPanel;
        private TextBox txtSearchName;
        private Label lblName;
    }
}