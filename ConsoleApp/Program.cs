using PayrollLibrary;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateOnly startDate = new DateOnly(2024, 5, 1);
            DateOnly endDate = new DateOnly(2024, 5, 10);

            var diff = endDate.DayNumber - startDate.DayNumber;

            if (diff < 0)
                throw new Exception("Start date must not be bigger than end date");

            var currentDay = startDate;

            List<Attendance> attendances = new List<Attendance>();

            for (int i = 1; i <= diff + 1; i++)
            {
                attendances.Add(new Attendance(currentDay));
                currentDay = currentDay.AddDays(1);
            }

            foreach (Attendance attendance in attendances)
            {
                Console.WriteLine(attendance.DateName);
            }
        }
    }
}
