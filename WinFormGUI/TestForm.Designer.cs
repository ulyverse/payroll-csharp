namespace Payroll_System_Tentative
{
    partial class TestForm
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
            monTimeinMorning = new DateTimePicker();
            monTimeoutMorning = new DateTimePicker();
            monTimeoutAfterNoon = new DateTimePicker();
            monTimeinAfterNoon = new DateTimePicker();
            monTimeoutOT = new DateTimePicker();
            monTimeinOT = new DateTimePicker();
            lblRate = new Label();
            lblTotalHours = new Label();
            lblOvertime = new Label();
            lblGrossPay = new Label();
            btnCalculateGrossPay = new Button();
            lblOTMultiplier = new Label();
            SuspendLayout();
            // 
            // monTimeinMorning
            // 
            monTimeinMorning.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinMorning.CustomFormat = "hh:mm tt";
            monTimeinMorning.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinMorning.Format = DateTimePickerFormat.Custom;
            monTimeinMorning.Location = new Point(44, 79);
            monTimeinMorning.Name = "monTimeinMorning";
            monTimeinMorning.ShowUpDown = true;
            monTimeinMorning.Size = new Size(117, 31);
            monTimeinMorning.TabIndex = 6;
            monTimeinMorning.Value = new DateTime(2024, 4, 30, 8, 0, 0, 0);
            // 
            // monTimeoutMorning
            // 
            monTimeoutMorning.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutMorning.CustomFormat = "hh:mm tt";
            monTimeoutMorning.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutMorning.Format = DateTimePickerFormat.Custom;
            monTimeoutMorning.Location = new Point(181, 79);
            monTimeoutMorning.Name = "monTimeoutMorning";
            monTimeoutMorning.ShowUpDown = true;
            monTimeoutMorning.Size = new Size(117, 31);
            monTimeoutMorning.TabIndex = 7;
            monTimeoutMorning.Value = new DateTime(2024, 4, 30, 12, 0, 0, 0);
            // 
            // monTimeoutAfterNoon
            // 
            monTimeoutAfterNoon.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutAfterNoon.CustomFormat = "hh:mm tt";
            monTimeoutAfterNoon.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutAfterNoon.Format = DateTimePickerFormat.Custom;
            monTimeoutAfterNoon.Location = new Point(462, 79);
            monTimeoutAfterNoon.Name = "monTimeoutAfterNoon";
            monTimeoutAfterNoon.ShowUpDown = true;
            monTimeoutAfterNoon.Size = new Size(117, 31);
            monTimeoutAfterNoon.TabIndex = 9;
            monTimeoutAfterNoon.Value = new DateTime(2024, 4, 30, 17, 0, 0, 0);
            // 
            // monTimeinAfterNoon
            // 
            monTimeinAfterNoon.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinAfterNoon.CustomFormat = "hh:mm tt";
            monTimeinAfterNoon.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinAfterNoon.Format = DateTimePickerFormat.Custom;
            monTimeinAfterNoon.Location = new Point(325, 79);
            monTimeinAfterNoon.Name = "monTimeinAfterNoon";
            monTimeinAfterNoon.ShowUpDown = true;
            monTimeinAfterNoon.Size = new Size(117, 31);
            monTimeinAfterNoon.TabIndex = 8;
            monTimeinAfterNoon.Value = new DateTime(2024, 4, 30, 13, 0, 0, 0);
            // 
            // monTimeoutOT
            // 
            monTimeoutOT.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutOT.CustomFormat = "hh:mm tt";
            monTimeoutOT.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeoutOT.Format = DateTimePickerFormat.Custom;
            monTimeoutOT.Location = new Point(740, 79);
            monTimeoutOT.Name = "monTimeoutOT";
            monTimeoutOT.ShowUpDown = true;
            monTimeoutOT.Size = new Size(117, 31);
            monTimeoutOT.TabIndex = 11;
            monTimeoutOT.Value = new DateTime(2024, 4, 30, 21, 0, 0, 0);
            // 
            // monTimeinOT
            // 
            monTimeinOT.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinOT.CustomFormat = "hh:mm tt";
            monTimeinOT.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monTimeinOT.Format = DateTimePickerFormat.Custom;
            monTimeinOT.Location = new Point(603, 79);
            monTimeinOT.Name = "monTimeinOT";
            monTimeinOT.ShowUpDown = true;
            monTimeinOT.Size = new Size(117, 31);
            monTimeinOT.TabIndex = 10;
            monTimeinOT.Value = new DateTime(2024, 4, 30, 19, 0, 0, 0);
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Verdana", 14.25F);
            lblRate.Location = new Point(44, 28);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(68, 23);
            lblRate.TabIndex = 12;
            lblRate.Text = "Rate: ";
            // 
            // lblTotalHours
            // 
            lblTotalHours.AutoSize = true;
            lblTotalHours.Font = new Font("Verdana", 14.25F);
            lblTotalHours.Location = new Point(44, 232);
            lblTotalHours.Name = "lblTotalHours";
            lblTotalHours.Size = new Size(128, 23);
            lblTotalHours.TabIndex = 13;
            lblTotalHours.Text = "Total Hours:";
            // 
            // lblOvertime
            // 
            lblOvertime.AutoSize = true;
            lblOvertime.Font = new Font("Verdana", 14.25F);
            lblOvertime.Location = new Point(44, 280);
            lblOvertime.Name = "lblOvertime";
            lblOvertime.Size = new Size(113, 23);
            lblOvertime.TabIndex = 14;
            lblOvertime.Text = "Overtime: ";
            // 
            // lblGrossPay
            // 
            lblGrossPay.AutoSize = true;
            lblGrossPay.Font = new Font("Verdana", 14.25F);
            lblGrossPay.Location = new Point(43, 368);
            lblGrossPay.Name = "lblGrossPay";
            lblGrossPay.Size = new Size(114, 23);
            lblGrossPay.TabIndex = 15;
            lblGrossPay.Text = "Gross Pay:";
            // 
            // btnCalculateGrossPay
            // 
            btnCalculateGrossPay.Font = new Font("Segoe UI", 14.25F);
            btnCalculateGrossPay.Location = new Point(386, 156);
            btnCalculateGrossPay.Name = "btnCalculateGrossPay";
            btnCalculateGrossPay.Size = new Size(128, 37);
            btnCalculateGrossPay.TabIndex = 16;
            btnCalculateGrossPay.Text = "Calculate";
            btnCalculateGrossPay.UseVisualStyleBackColor = true;
            btnCalculateGrossPay.Click += btnCalculateGrossPay_Click;
            // 
            // lblOTMultiplier
            // 
            lblOTMultiplier.AutoSize = true;
            lblOTMultiplier.Font = new Font("Verdana", 14.25F);
            lblOTMultiplier.Location = new Point(69, 322);
            lblOTMultiplier.Name = "lblOTMultiplier";
            lblOTMultiplier.Size = new Size(222, 23);
            lblOTMultiplier.TabIndex = 17;
            lblOTMultiplier.Text = "Overtime Multiplier: 1";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(lblOTMultiplier);
            Controls.Add(btnCalculateGrossPay);
            Controls.Add(lblGrossPay);
            Controls.Add(lblOvertime);
            Controls.Add(lblTotalHours);
            Controls.Add(lblRate);
            Controls.Add(monTimeoutOT);
            Controls.Add(monTimeinOT);
            Controls.Add(monTimeoutAfterNoon);
            Controls.Add(monTimeinAfterNoon);
            Controls.Add(monTimeoutMorning);
            Controls.Add(monTimeinMorning);
            Name = "TestForm";
            Text = "TestForm";
            Load += TestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker monTimeinMorning;
        private DateTimePicker monTimeoutMorning;
        private DateTimePicker monTimeoutAfterNoon;
        private DateTimePicker monTimeinAfterNoon;
        private DateTimePicker monTimeoutOT;
        private DateTimePicker monTimeinOT;
        private Label lblRate;
        private Label lblTotalHours;
        private Label lblOvertime;
        private Label lblGrossPay;
        private Button btnCalculateGrossPay;
        private Label lblOTMultiplier;
    }
}