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
            lblOvertime = new Label();
            lblGrossPay = new Label();
            lblRate = new Label();
            SuspendLayout();
            // 
            // pnlAttendance
            // 
            pnlAttendance.AutoScroll = true;
            pnlAttendance.BackColor = Color.White;
            pnlAttendance.BorderStyle = BorderStyle.FixedSingle;
            pnlAttendance.FlowDirection = FlowDirection.TopDown;
            pnlAttendance.Location = new Point(16, 111);
            pnlAttendance.Name = "pnlAttendance";
            pnlAttendance.Size = new Size(1040, 255);
            pnlAttendance.TabIndex = 0;
            pnlAttendance.WrapContents = false;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(258, 20);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(303, 35);
            lblEmployeeName.TabIndex = 2;
            lblEmployeeName.Text = "EMPLOYEE_NAME";
            // 
            // lblMorningTimein
            // 
            lblMorningTimein.AutoSize = true;
            lblMorningTimein.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMorningTimein.Location = new Point(258, 79);
            lblMorningTimein.Name = "lblMorningTimein";
            lblMorningTimein.Size = new Size(71, 18);
            lblMorningTimein.TabIndex = 3;
            lblMorningTimein.Text = "Time in";
            // 
            // lblMorningTimeout
            // 
            lblMorningTimeout.AutoSize = true;
            lblMorningTimeout.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMorningTimeout.Location = new Point(389, 79);
            lblMorningTimeout.Name = "lblMorningTimeout";
            lblMorningTimeout.Size = new Size(85, 18);
            lblMorningTimeout.TabIndex = 4;
            lblMorningTimeout.Text = "Time out";
            // 
            // lblAfternoonTimein
            // 
            lblAfternoonTimein.AutoSize = true;
            lblAfternoonTimein.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfternoonTimein.Location = new Point(520, 79);
            lblAfternoonTimein.Name = "lblAfternoonTimein";
            lblAfternoonTimein.Size = new Size(71, 18);
            lblAfternoonTimein.TabIndex = 5;
            lblAfternoonTimein.Text = "Time in";
            // 
            // lblAfternoonTimeout
            // 
            lblAfternoonTimeout.AutoSize = true;
            lblAfternoonTimeout.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAfternoonTimeout.Location = new Point(648, 79);
            lblAfternoonTimeout.Name = "lblAfternoonTimeout";
            lblAfternoonTimeout.Size = new Size(85, 18);
            lblAfternoonTimeout.TabIndex = 6;
            lblAfternoonTimeout.Text = "Time out";
            // 
            // lblOvertimeTimein
            // 
            lblOvertimeTimein.AutoSize = true;
            lblOvertimeTimein.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOvertimeTimein.Location = new Point(780, 79);
            lblOvertimeTimein.Name = "lblOvertimeTimein";
            lblOvertimeTimein.Size = new Size(71, 18);
            lblOvertimeTimein.TabIndex = 7;
            lblOvertimeTimein.Text = "Time in";
            // 
            // lblOvertimeTimeout
            // 
            lblOvertimeTimeout.AutoSize = true;
            lblOvertimeTimeout.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOvertimeTimeout.Location = new Point(908, 79);
            lblOvertimeTimeout.Name = "lblOvertimeTimeout";
            lblOvertimeTimeout.Size = new Size(85, 18);
            lblOvertimeTimeout.TabIndex = 8;
            lblOvertimeTimeout.Text = "Time out";
            // 
            // btnCalculatePay
            // 
            btnCalculatePay.Location = new Point(908, 383);
            btnCalculatePay.Name = "btnCalculatePay";
            btnCalculatePay.Size = new Size(148, 40);
            btnCalculatePay.TabIndex = 9;
            btnCalculatePay.Text = "Calculate";
            btnCalculatePay.UseVisualStyleBackColor = true;
            btnCalculatePay.Click += CalculatePay;
            // 
            // lblNormalWorkingHours
            // 
            lblNormalWorkingHours.AutoSize = true;
            lblNormalWorkingHours.Location = new Point(16, 383);
            lblNormalWorkingHours.Name = "lblNormalWorkingHours";
            lblNormalWorkingHours.Size = new Size(198, 18);
            lblNormalWorkingHours.TabIndex = 10;
            lblNormalWorkingHours.Text = "Normal Working Hours:";
            // 
            // lblOvertime
            // 
            lblOvertime.AutoSize = true;
            lblOvertime.Location = new Point(424, 383);
            lblOvertime.Name = "lblOvertime";
            lblOvertime.Size = new Size(90, 18);
            lblOvertime.TabIndex = 11;
            lblOvertime.Text = "Overtime:";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Location = new Point(719, 383);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(96, 18);
            lblGrossPay.TabIndex = 12;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(762, 422);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(53, 18);
            lblRate.TabIndex = 13;
            lblRate.Text = "Rate:";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 469);
            Controls.Add(lblRate);
            Controls.Add(lblGrossPay);
            Controls.Add(lblOvertime);
            Controls.Add(lblNormalWorkingHours);
            Controls.Add(btnCalculatePay);
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
            Text = "Attendance Form";
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
        private Label lblOvertime;
        private Label lblGrossPay;
        private Label lblRate;
    }
}