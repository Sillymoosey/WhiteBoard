using System;

namespace ConvertingToInches
{
    class Program
    {
        public static int Converting(int feet)
        {
            int inches = 12;
            inches = feet * inches;
            return inches;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ConvertingToInches.Program.Main()");
            Console.WriteLine("How many feet do you need?");
            int feet = int.Parse(Console.ReadLine());
            Console.WriteLine($"Well {feet} feet is basically {Converting(feet)}, inches.");
        }
    }
}
