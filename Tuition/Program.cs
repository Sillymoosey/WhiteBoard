using System;

namespace Tuition
{
    class Program
    {
        public static void Interest()
        {
            double loan = 6000;
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += loan + (loan * 0.02);
                Console.WriteLine($"For year {i + 1} your tuition is {total}.");
            }

        }
        static void Main(string[] args)
        {
         Console.WriteLine("Tuition.Program.Main");
            Interest();
        }

    }
}
