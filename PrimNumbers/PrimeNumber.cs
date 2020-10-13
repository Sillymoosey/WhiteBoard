using System;

namespace PrimNumbers
{
    public class PrimeNumber
    {
        public static bool IsPrimeNumber(int p)
        {
            if(p % 2 == 0)
            {
                return false;
            }
            for (int i = 2; i < p; i++)
            {
                if(p % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNumber(4));
            Console.WriteLine(IsPrimeNumber(37));
        }
    }
}
