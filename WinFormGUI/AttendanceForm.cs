using PayrollLibrary;
using PayrollLibrary.Model;
using PayrollLibrary.ViewModel;

namespace WinFormGUI
{
    public partial class AttendanceForm : Form
    {
        public PayrollEmployeeDisplay _employee;
        private AttendanceController _attendanceController = new AttendanceController();
        private bool isSaving = false;
        public AttendanceForm(PayrollEmployeeDisplay employee)
        {
            InitializeComponent();
            _employee = employee;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = $"{_employee.Name.ToUpper()}";
            lblRate.Text = $"Rate: PHP {_employee.Rate}";
            lblBalance.Text = $"Balance: PHP {_employee.PreviousCashAdvance}";
            txtAmount.Text = _employee.CashAdvanceAmountToPay.ToString();
            ConfigureScrollBar();
            InitializeAttendanceForm();
            btnCalculatePay.PerformClick();
        }

        private void InitializeAttendanceForm()
        {
            CreateAttendanceSheetForm();
        }

        private void CreateAttendanceSheetForm()
        {
            pnlAttendance.SuspendLayout();
            bool alternate = true;
            foreach (var attendance in _employee.Attendances)
            {
                var panel = new FlowLayoutPanel();

                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.Parent = pnlAttendance;
                panel.AutoSize = true;

                if (!alternate)
                    panel.BackColor = Color.LightGray;

                alternate = !alternate;

                var lblDate = CreateDateLabel(attendance.DateName);
                lblDate.Parent = panel;

                var chkEnabled = CreateCheckBox(attendance);
                chkEnabled.Parent = panel;

                for (int i = 0; i < 6; i++)
                {
                    var timePicker = CreateTimeSpanPicker();

                    timePicker.Parent = panel;
                    timePicker.DataBindings.Add("Enabled", chkEnabled, "Checked");

                    var strProperty = i % 2 == 0 ? "TimeIn" : "TimeOut";
                    BindTimePickerToTimeBlock(timePicker, attendance.TimeBlocks[i / 2], strProperty);
                }
            }
            pnlAttendance.ResumeLayout();
        }

        public void BindTimePickerToTimeBlock(DateTimePicker timePicker, TimeBlock timeBlock, string property)
        {
            Binding timeBinding = new Binding("Value", timeBlock, property, true, DataSourceUpdateMode.OnPropertyChanged);
            timeBinding.Format += TimeBinding_Format;
            timeBinding.Parse += TimeBinding_Parse;

            timePicker.DataBindings.Add(timeBinding);
        }

        private void ConfigureScrollBar()
        {
            pnlAttendance.AutoScroll = false;
            pnlAttendance.HorizontalScroll.Enabled = false;
            pnlAttendance.HorizontalScroll.Visible = false;
            pnlAttendance.HorizontalScroll.Maximum = 0;
            pnlAttendance.AutoScroll = true;
        }

        public CheckBox CreateCheckBox(Attendance attendance)
        {
            CheckBox chkEnabled = new CheckBox();
            chkEnabled.Font = new Font("Segoe UI", 9);
            chkEnabled.Text = "In";
            chkEnabled.Width = 45;
            chkEnabled.Dock = DockStyle.Fill;
            chkEnabled.TextAlign = ContentAlignment.MiddleCenter;
            chkEnabled.DataBindings.Add("Checked", attendance, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged);
            return chkEnabled;
        }

        public Label CreateDateLabel(string text)
        {
            Label lblDate = new Label();
            lblDate.Font = new Font("Consolas", 14.5f, FontStyle.Regular);
            lblDate.Text = text;
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Fill;
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            return lblDate;
        }


        private DateTimePicker CreateTimeSpanPicker()
        {
            var dateTimePicker = new DateTimePicker();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "hh:mm tt";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(140, 30);
            dateTimePicker.Font = new Font("Verdana", 14, FontStyle.Regular);
            dateTimePicker.Value = new DateTime(2015, 5, 10, 8, 0, 0);
            dateTimePicker.Margin = new Padding(5, 0, 5, 0);
            return dateTimePicker;
        }
        private void TimeBinding_Format(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(DateTime) || !(e.Value is TimeOnly timeOnly)) return;

            e.Value = DateTime.Today.Add(timeOnly.ToTimeSpan());
        }
        private void TimeBinding_Parse(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType != typeof(TimeOnly) || !(e.Value is DateTime dateTime)) return;

            e.Value = TimeOnly.FromDateTime(dateTime);
        }
        private void btn_CalculatePay(object sender, EventArgs e)
        {
            CalculatePay();
        }

        private void CalculatePay()
        {
            _employee.NormalHours = _attendanceController.GetTotalNormalWorkingHours(_employee.Attendances).TotalHours;
            _employee.Overtime = _attendanceController.GetTotalOverTime(_employee.Attendances).TotalHours;
            _employee.CalculateGrossPay();

            lblNormalWorkingHours.Text = $"Normal Hours: {_employee.NormalHours}";
            lblOvertimeHours.Text = $"Overtime: {_employee.Overtime}";
            lblGrossPay.Text = $"Gross Pay: {_employee.GrossPay}";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (!decimal.TryParse(txtAmount.Text.Trim(), out amount))
            {
                MessageBoxPrompt.ShowInfo("Amount must be a valid input");
            }
            else if (amount < 0 || amount > _employee.PreviousCashAdvance)
            {
                MessageBoxPrompt.ShowInfo("Amount must be in between 0 and the current balance");
            }
            else
            {
                var dialogResult = MessageBoxPrompt.YesNoPrompt("Do you want to calculate and save changes now?", "Save Changes");
                if (dialogResult == DialogResult.Yes)
                {
                    _employee.CashAdvanceAmountToPay = amount;
                    _employee.CalculateNextCashAdvance();
                    _employee.CalculateTotalDeductions();
                    isSaving = true;
                    CalculatePay();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void AttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaving)
            {
                if (MessageBoxPrompt.Exit("Do you want to close this attendance form?") == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
