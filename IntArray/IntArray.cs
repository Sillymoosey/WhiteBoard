using System;

namespace IntArray
{
    public class IntArray
    {
        //count distinct elements of an array
        public static int Distinct(int[] array)
        {
            int count = 0;
            int total = array.Length;
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                }
            }
            return total - count;

        }
        
        static void Main(string[] args)
        {
            //int[] ArrayA = { 8, 8, 9, 0, 1 };
            //Console.WriteLine(Distinct(ArrayA));
        }
    }
}
