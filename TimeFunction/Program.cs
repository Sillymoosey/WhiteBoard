using System;

namespace TimeFunction
{
    public class Program
    {
        public static int timeBetween(int hrs1, int min1, int hrs2, int min2)
        {
            int totalMinutes = 0;
            min1 += hrs1 * 60;
            min2 += hrs2 * 60;
            totalMinutes = min1 - min2;
            if (totalMinutes < 0)
            {
                totalMinutes = totalMinutes * -1;
            }

            return totalMinutes;
        }
        static void Main(string[] args)
        {
        
        }
    }
}
