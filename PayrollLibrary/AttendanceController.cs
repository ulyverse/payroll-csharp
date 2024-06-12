using PayrollLibrary.Model;
using System.Globalization;

namespace PayrollLibrary
{
    public class AttendanceController
    {

        public static List<Attendance> GetAttendances(DateOnly startDate, DateOnly endDate)
        {
            List<Attendance> attendances = new List<Attendance>();

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
    }
}
