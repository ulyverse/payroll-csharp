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
            dateStopDate = new DateTimePicker();
            lblStartDate = new Label();
            lblStopDate = new Label();
            btnDemo = new Button();
            SuspendLayout();
            // 
            // dateStartDate
            // 
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(62, 116);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(103, 23);
            dateStartDate.TabIndex = 0;
            // 
            // dateStopDate
            // 
            dateStopDate.Format = DateTimePickerFormat.Short;
            dateStopDate.Location = new Point(205, 116);
            dateStopDate.Name = "dateStopDate";
            dateStopDate.Size = new Size(103, 23);
            dateStopDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(63, 84);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(61, 15);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "Start Date:";
            // 
            // lblStopDate
            // 
            lblStopDate.AutoSize = true;
            lblStopDate.Location = new Point(205, 84);
            lblStopDate.Name = "lblStopDate";
            lblStopDate.Size = new Size(57, 15);
            lblStopDate.TabIndex = 3;
            lblStopDate.Text = "End Date:";
            // 
            // btnDemo
            // 
            btnDemo.Location = new Point(62, 163);
            btnDemo.Name = "btnDemo";
            btnDemo.Size = new Size(245, 40);
            btnDemo.TabIndex = 4;
            btnDemo.Text = "Demo";
            btnDemo.UseVisualStyleBackColor = true;
            btnDemo.Click += btnDemo_Click;
            // 
            // CreatePayrollForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 286);
            Controls.Add(btnDemo);
            Controls.Add(lblStopDate);
            Controls.Add(lblStartDate);
            Controls.Add(dateStopDate);
            Controls.Add(dateStartDate);
            Name = "CreatePayrollForm";
            Text = "Create Payroll Form";
            Load += CreatePayrollForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateStartDate;
        private DateTimePicker dateStopDate;
        private Label lblStartDate;
        private Label lblStopDate;
        private Button btnDemo;
    }
}