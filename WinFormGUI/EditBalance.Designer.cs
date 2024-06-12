namespace WinFormGUI
{
    partial class EditBalance
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
            lblName = new Label();
            lblBalance = new Label();
            txtBalance = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            lblEmployeeName = new Label();
            rbtnCashAdvance = new RadioButton();
            rbtnSnack = new RadioButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(120, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(120, 79);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(64, 14);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Amount: ";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(191, 76);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(94, 22);
            txtBalance.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(214, 196);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeName.Location = new Point(178, 50);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(122, 14);
            lblEmployeeName.TabIndex = 5;
            lblEmployeeName.Text = "EMPLOYEE NAME";
            // 
            // rbtnCashAdvance
            // 
            rbtnCashAdvance.AutoSize = true;
            rbtnCashAdvance.Location = new Point(145, 121);
            rbtnCashAdvance.Name = "rbtnCashAdvance";
            rbtnCashAdvance.Size = new Size(114, 18);
            rbtnCashAdvance.TabIndex = 6;
            rbtnCashAdvance.TabStop = true;
            rbtnCashAdvance.Text = "Cash Advance";
            rbtnCashAdvance.UseVisualStyleBackColor = true;
            // 
            // rbtnSnack
            // 
            rbtnSnack.AutoSize = true;
            rbtnSnack.Location = new Point(145, 145);
            rbtnSnack.Name = "rbtnSnack";
            rbtnSnack.Size = new Size(62, 18);
            rbtnSnack.TabIndex = 7;
            rbtnSnack.TabStop = true;
            rbtnSnack.Text = "Snack";
            rbtnSnack.UseVisualStyleBackColor = true;
            // 
            // EditBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 268);
            Controls.Add(rbtnSnack);
            Controls.Add(rbtnCashAdvance);
            Controls.Add(lblEmployeeName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtBalance);
            Controls.Add(lblBalance);
            Controls.Add(lblName);
            Font = new Font("Verdana", 9F);
            Name = "EditBalance";
            Text = "Edit Balance";
            FormClosing += EditBalance_FormClosing;
            Load += EditBalance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblBalance;
        private TextBox txtBalance;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblEmployeeName;
        private RadioButton rbtnCashAdvance;
        private RadioButton rbtnSnack;
    }
}