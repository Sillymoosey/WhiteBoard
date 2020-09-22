using System;

namespace Collections
{
    class Collections
    {
        static Random r = new Random();
        static int[] Tests(int n = 5)
        {
            int[] testScore = new int[n];
            for (int i = 0; i < n; i++)
            {
                testScore[i] = r.Next(1, 101);
            }
            return testScore;
        }
        static double Average(int[] Tests)
        {
            double average = 0.0;
            for (int i = 0; i < Tests.Length; i++)
            {
                average += Tests[i];
            }
            return average / Tests.Length;
        }
        static int GetMax(int[] Tests)
        {
            int max = Tests[0];
            //for (int i = 0; i < Tests.Length; i++)
            //{
            //    if (Tests[i] > max)
            //    {
            //        max = Tests[i];
            //    }
            //
            //}
            foreach (var item in Tests)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        static int[] Sort(int[] tests)
        {
            int index1 = 0;
            int index2 = 1;
            bool toggle = false;
            while (index2 < tests.Length)
            {
                if(tests[index1] > tests[index2])
                {
                    int temp = tests[index1];
                    tests[index1] = tests[index2];
                    tests[index2] = temp;
                    toggle = true;
                }

                index1++;
                index2++;
            }
            if(toggle == true)
            {
                return Sort(tests);
            }
            return tests;
        }
        static void Main(string[] args)
        {
            int[] scores = Tests(20);
            Sort(scores);
            Console.WriteLine("Your scores are:");
            foreach (var item in scores)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"your Test Average is: {Average(scores)}");
            Console.WriteLine($"your high score is {GetMax(scores)}");
        }
    }
}