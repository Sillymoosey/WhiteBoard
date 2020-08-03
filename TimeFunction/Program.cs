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
        static void Main(string[] args)
        {
        
        }
    }
}
