using System;

namespace DateWeek
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter the date to establish day of week with YYYY-MM-DD form: ");
            try
            {
                var date = Convert.ToDateTime(Console.ReadLine());
                var weekday = (date.DayOfWeek);
                Console.WriteLine("Day of Week: ", weekday);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Error form");
                Main();
            }


        }
    }
}
