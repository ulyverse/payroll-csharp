using PayrollLibrary;

namespace WinFormGUI
{
    public partial class CreatePayrollForm : Form
    {
        private Employee employee;
        public CreatePayrollForm()
        {
            InitializeComponent();
        }

        private void CreatePayrollForm_Load(object sender, EventArgs e)
        {
            employee = new Employee() { FirstName = "Cardo", LastName = "Dalisay", Salary = 50 };

        }

        private List<Attendance> GetAttendances()
        {
            List<Attendance> attendances = new List<Attendance>();

            DateOnly startDate = DateOnly.FromDateTime(dateStartDate.Value);
            DateOnly endDate = DateOnly.FromDateTime(dateStopDate.Value);

            var diff = endDate.DayNumber - startDate.DayNumber;

            if (diff < 0)
                throw new Exception("Start date must not be bigger than end date");

            var currentDay = startDate;

            for (int i = 1; i <= diff + 1; i++)
            {
                attendances.Add(new Attendance(currentDay));
                currentDay = currentDay.AddDays(1);
            }
            return attendances;
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            employee.Attendances = GetAttendances();
            new AttendanceForm(employee).ShowDialog();
        }
    }
}
