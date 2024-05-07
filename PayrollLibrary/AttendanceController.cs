using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public class AttendanceController
    {
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
