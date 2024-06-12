namespace WinFormGUI
{
    partial class CreatePayrollForm
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
            dateStartDate = new DateTimePicker();
            dateEndDate = new DateTimePicker();
            lblStartDate = new Label();
            lblStopDate = new Label();
            btnCreatePayroll = new Button();
            checkDetailedDeduction = new CheckBox();
            SuspendLayout();
            // 
            // dateEndDate
            // 
            dateEndDate.Format = DateTimePickerFormat.Short;
            dateEndDate.Location = new Point(269, 117);
            dateEndDate.Margin = new Padding(4);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.Size = new Size(145, 27);
            dateEndDate.TabIndex = 1;
            // 
            // dateStartDate
            // 
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(71, 117);
            dateStartDate.Margin = new Padding(4);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(145, 27);
            dateStartDate.TabIndex = 0;

            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(72, 79);
            lblStartDate.Margin = new Padding(4, 0, 4, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(100, 18);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // lblStopDate
            // 
            lblStopDate.AutoSize = true;
            lblStopDate.Location = new Point(269, 79);
            lblStopDate.Margin = new Padding(4, 0, 4, 0);
            lblStopDate.Name = "lblStopDate";
            lblStopDate.Size = new Size(90, 18);
            lblStopDate.TabIndex = 3;
            lblStopDate.Text = "End Date:";
            // 
            // btnCreatePayroll
            // 
            btnCreatePayroll.Location = new Point(72, 213);
            btnCreatePayroll.Margin = new Padding(4);
            btnCreatePayroll.Name = "btnCreatePayroll";
            btnCreatePayroll.Size = new Size(342, 48);
            btnCreatePayroll.TabIndex = 4;
            btnCreatePayroll.Text = "Create Payroll";
            btnCreatePayroll.UseVisualStyleBackColor = true;
            btnCreatePayroll.Click += btnCreatePayroll_Click;
            // 
            // checkDetailedDeduction
            // 
            checkDetailedDeduction.AutoSize = true;
            checkDetailedDeduction.Font = new Font("Verdana", 10F);
            checkDetailedDeduction.Location = new Point(72, 170);
            checkDetailedDeduction.Name = "checkDetailedDeduction";
            checkDetailedDeduction.Size = new Size(347, 21);
            checkDetailedDeduction.TabIndex = 5;
            checkDetailedDeduction.Text = "Include SSS, PagIbig, Philhealth  in Deduction";
            checkDetailedDeduction.UseVisualStyleBackColor = true;
            // 
            // CreatePayrollForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 341);
            Controls.Add(checkDetailedDeduction);
            Controls.Add(btnCreatePayroll);
            Controls.Add(lblStopDate);
            Controls.Add(lblStartDate);
            Controls.Add(dateEndDate);
            Controls.Add(dateStartDate);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "CreatePayrollForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Payroll";
            Load += CreatePayrollForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateStartDate;
        private DateTimePicker dateEndDate;
        private Label lblStartDate;
        private Label lblStopDate;
        private Button btnCreatePayroll;
        private CheckBox checkDetailedDeduction;
    }
}