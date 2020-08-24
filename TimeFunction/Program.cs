using System;

namespace TimeFunction
{
    public class Program
    {
        public static int timeBetween(DateTime Time1, DateTime Time2)
        {
            int totalMinutes = DateTime.Compare(Time1, Time2);
            return totalMinutes;
        }
        public static int Julian(DateTime Pax)
        {
            int day = Pax.Day;
            
            //int jDate = Convert.ToInt32(julianDate);
            //int day = jDate % 1000;
            //int year = (jDate - day) / 1000;
            //var date1 = new DateTime(year, 1, 1);
            //var result = date1.AddDays(day - 1);
            return day;
        }
        static void Main(string[] args)
        {
            DateTime Time2 = new DateTime(2020, 2, 2);
            Console.WriteLine(Julian(Time2));
        }
    }
}
