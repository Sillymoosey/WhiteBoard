using System;

namespace Bucket_of_ints
{
    public class Buckit
    {
        static Random r = new Random();

        public static int[] GetBucketOfInts(int size = 10)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(0, 20);
            }
            int min = 0;
            int max = numbers.Length - 1;
            return SortBucketOfInts(numbers, min, max);
            
        }

        public static int[] SortBucketOfInts(int[] input, int min, int max)
        {
            int holder = 0;
            int swapper = 0;
            while (min <= max)
            {
                int mid = (min + max) / 2;

                // if (input[min] == input[mid])
                // {
                //    
                //   
                // }
                if (input[min] < input[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    holder = input[min];
                    swapper = input[mid];
                    input[mid] = input[holder];
                    input[min] = input[swapper];
                    min = mid + 1;
                }
            }
            return input;

        }
    }
}

