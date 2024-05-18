using System.Globalization;

namespace PayrollLibrary
{
    public class AttendanceController
    {
        public TimeSpan GetTotalNormalWorkingHours(List<Attendance> attendances)
        {
            var timeSpan = new TimeSpan();
            foreach (var attendance in attendances)
            {
                if (!attendance.Enabled)
                    continue;
                timeSpan += attendance.NormalWorkingHours;
            }
            return timeSpan;
        }

        public TimeSpan GetTotalOverTime(List<Attendance> attendances)
        {
            var timeSpan = new TimeSpan();
            foreach (var attendance in attendances)
            {
                if (!attendance.Enabled)
                    continue;
                timeSpan += attendance.OverTime;
            }
            return timeSpan;
        }

        public TimeSpan ParseTime(string text)
        {
            return DateTime.ParseExact(text, "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
        }

        public TimeSpan GetHoursSpent(TimeSpan start, TimeSpan end)
        {
            TimeSpan range = end - start;
            if (range.TotalHours <= 0)
                return TimeSpan.Zero;

            return range;
        }

        public double GetTimeInHours(TimeSpan time)
        {
            return time.TotalHours;
        }

        public TimeSpan GetTotalHours(TimeSpan morningTotalHours, TimeSpan afternooonTotalHours)
        {
            return morningTotalHours + afternooonTotalHours;
        }

        public double GetGrossPay(Employee employee, TimeSpan normalWorkingHours, TimeSpan overtimeHours, double overtimeMultiplier = 1)
        {
            return GetGrossPay(normalWorkingHours.TotalHours, overtimeHours.TotalHours, overtimeMultiplier, employee.Salary);
        }

        public double GetGrossPay(double totalHours, double overtimeHours, double overtimeMultiplier, double ratePerHour)
        {
            double normalPay = totalHours * ratePerHour;
            double overtimePay = (overtimeHours * overtimeMultiplier) * ratePerHour;

            return Math.Round(normalPay + overtimePay, 2);
        }

        public double GetGrossPay(TimeSpan totalHours, TimeSpan overtimeHours, double overtimeMultiplier, double ratePerHour)
        {
            return GetGrossPay(GetTimeInHours(totalHours), GetTimeInHours(overtimeHours), overtimeMultiplier, ratePerHour);
        }
    }
}
