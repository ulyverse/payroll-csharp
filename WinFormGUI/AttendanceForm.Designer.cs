namespace WinFormGUI
{
    partial class AttendanceForm
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
            pnlAttendance = new FlowLayoutPanel();
            lblEmployeeName = new Label();
            lblMorningTimein = new Label();
            lblMorningTimeout = new Label();
            lblAfternoonTimein = new Label();
            lblAfternoonTimeout = new Label();
            lblOvertimeTimein = new Label();
            lblOvertimeTimeout = new Label();
            btnCalculatePay = new Button();
            lblNormalWorkingHours = new Label();
            lblOvertimeHours = new Label();
            lblGrossPay = new Label();
            lblRate = new Label();
            lblMorning = new Label();
            lblAfternoon = new Label();
            lblOvertime = new Label();
            btnSave = new Button();
            lblBalance = new Label();
            lblAmount = new Label();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // pnlAttendance
            // 
            pnlAttendance.AutoScroll = true;
            pnlAttendance.BackColor = Color.White;
            pnlAttendance.BorderStyle = BorderStyle.FixedSingle;
            pnlAttendance.FlowDirection = FlowDirection.TopDown;
            pnlAttendance.Location = new Point(16, 137);
            pnlAttendance.Name = "pnlAttendance";
            pnlAttendance.Size = new Size(1226, 300);
            pnlAttendance.TabIndex = 0;
            pnlAttendance.WrapContents = false;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(317, 20);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(385, 45);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "EMPLOYEE_NAME";
            // 
            // lblMorningTimein
            // 
            lblMorningTimein.AutoSize = true;
            lblMorningTimein.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorningTimein.Location = new Point(319, 106);
            lblMorningTimein.Name = "lblMorningTimein";
            lblMorningTimein.Size = new Size(87, 25);
            lblMorningTimein.TabIndex = 3;
            lblMorningTimein.Text = "Time in";
            // 
            // lblMorningTimeout
            // 
            lblMorningTimeout.AutoSize = true;
            lblMorningTimeout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMorningTimeout.Location = new Point(470, 105);
            lblMorningTimeout.Name = "lblMorningTimeout";
            lblMorningTimeout.Size = new Size(101, 25);
            lblMorningTimeout.TabIndex = 4;
            lblMorningTimeout.Text = "Time out";
            // 
            // lblAfternoonTimein
            // 
            lblAfternoonTimein.AutoSize = true;
            lblAfternoonTimein.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAfternoonTimein.Location = new Point(620, 105);
            lblAfternoonTimein.Name = "lblAfternoonTimein";
            lblAfternoonTimein.Size = new Size(87, 25);
            lblAfternoonTimein.TabIndex = 5;
            lblAfternoonTimein.Text = "Time in";
            // 
            // lblAfternoonTimeout
            // 
            lblAfternoonTimeout.AutoSize = true;
            lblAfternoonTimeout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAfternoonTimeout.Location = new Point(768, 105);
            lblAfternoonTimeout.Name = "lblAfternoonTimeout";
            lblAfternoonTimeout.Size = new Size(101, 25);
            lblAfternoonTimeout.TabIndex = 6;
            lblAfternoonTimeout.Text = "Time out";
            // 
            // lblOvertimeTimein
            // 
            lblOvertimeTimein.AutoSize = true;
            lblOvertimeTimein.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOvertimeTimein.Location = new Point(918, 105);
            lblOvertimeTimein.Name = "lblOvertimeTimein";
            lblOvertimeTimein.Size = new Size(87, 25);
            lblOvertimeTimein.TabIndex = 7;
            lblOvertimeTimein.Text = "Time in";
            // 
            // lblOvertimeTimeout
            // 
            lblOvertimeTimeout.AutoSize = true;
            lblOvertimeTimeout.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOvertimeTimeout.Location = new Point(1069, 105);
            lblOvertimeTimeout.Name = "lblOvertimeTimeout";
            lblOvertimeTimeout.Size = new Size(101, 25);
            lblOvertimeTimeout.TabIndex = 8;
            lblOvertimeTimeout.Text = "Time out";
            // 
            // btnCalculatePay
            // 
            btnCalculatePay.Location = new Point(1088, 445);
            btnCalculatePay.Name = "btnCalculatePay";
            btnCalculatePay.Size = new Size(148, 40);
            btnCalculatePay.TabIndex = 9;
            btnCalculatePay.Text = "Calculate";
            btnCalculatePay.UseVisualStyleBackColor = true;
            btnCalculatePay.Click += btn_CalculatePay;
            // 
            // lblNormalWorkingHours
            // 
            lblNormalWorkingHours.AutoSize = true;
            lblNormalWorkingHours.Location = new Point(246, 453);
            lblNormalWorkingHours.Name = "lblNormalWorkingHours";
            lblNormalWorkingHours.Size = new Size(160, 25);
            lblNormalWorkingHours.TabIndex = 10;
            lblNormalWorkingHours.Text = "Normal Hours:";
            // 
            // lblOvertimeHours
            // 
            lblOvertimeHours.AutoSize = true;
            lblOvertimeHours.Location = new Point(514, 453);
            lblOvertimeHours.Name = "lblOvertimeHours";
            lblOvertimeHours.Size = new Size(115, 25);
            lblOvertimeHours.TabIndex = 11;
            lblOvertimeHours.Text = "Overtime:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Location = new Point(825, 453);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(121, 25);
            lblGrossPay.TabIndex = 12;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(33, 453);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(67, 25);
            lblRate.TabIndex = 13;
            lblRate.Text = "Rate:";
            // 
            // lblMorning
            // 
            lblMorning.AutoSize = true;
            lblMorning.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMorning.Location = new Point(319, 73);
            lblMorning.Name = "lblMorning";
            lblMorning.Size = new Size(167, 32);
            lblMorning.TabIndex = 14;
            lblMorning.Text = "MORNING";
            // 
            // lblAfternoon
            // 
            lblAfternoon.AutoSize = true;
            lblAfternoon.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfternoon.Location = new Point(620, 73);
            lblAfternoon.Name = "lblAfternoon";
            lblAfternoon.Size = new Size(202, 32);
            lblAfternoon.TabIndex = 15;
            lblAfternoon.Text = "AFTERNOON";
            // 
            // lblOvertime
            // 
            lblOvertime.AutoSize = true;
            lblOvertime.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOvertime.Location = new Point(918, 73);
            lblOvertime.Name = "lblOvertime";
            lblOvertime.Size = new Size(174, 32);
            lblOvertime.TabIndex = 16;
            lblOvertime.Text = "OVERTIME";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1088, 491);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 40);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(514, 499);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(100, 25);
            lblBalance.TabIndex = 18;
            lblBalance.Text = "Balance:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(827, 499);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 25);
            lblAmount.TabIndex = 19;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(933, 496);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(117, 32);
            txtAmount.TabIndex = 20;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 543);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(lblBalance);
            Controls.Add(lblGrossPay);
            Controls.Add(btnSave);
            Controls.Add(btnCalculatePay);
            Controls.Add(lblOvertime);
            Controls.Add(lblNormalWorkingHours);
            Controls.Add(lblOvertimeHours);
            Controls.Add(lblAfternoon);
            Controls.Add(lblRate);
            Controls.Add(lblMorning);
            Controls.Add(lblOvertimeTimeout);
            Controls.Add(lblOvertimeTimein);
            Controls.Add(lblAfternoonTimeout);
            Controls.Add(lblAfternoonTimein);
            Controls.Add(lblMorningTimeout);
            Controls.Add(lblMorningTimein);
            Controls.Add(lblEmployeeName);
            Controls.Add(pnlAttendance);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            FormClosing += AttendanceForm_FormClosing;
            Load += AttendanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel pnlAttendance;
        private Label lblEmployeeName;
        private Label lblMorningTimein;
        private Label lblMorningTimeout;
        private Label lblAfternoonTimein;
        private Label lblAfternoonTimeout;
        private Label lblOvertimeTimein;
        private Label lblOvertimeTimeout;
        private Button btnCalculatePay;
        private Label lblNormalWorkingHours;
        private Label lblOvertimeHours;
        private Label lblGrossPay;
        private Label lblRate;
        private Label lblMorning;
        private Label lblAfternoon;
        private Label lblOvertime;
        private Button btnSave;
        private Label lblBalance;
        private Label lblAmount;
        private TextBox txtAmount;
    }
}