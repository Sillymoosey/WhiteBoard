using System;

namespace compare
{
    class Program
    {
		//pass two intigers
		//return a string that compares the two numbers
		public static string compare(int first, int second)
		{
			string output;
			if (first > second)
			{
				return output = $"{first} is larger than {second}";
			}
			else
			{
				return output = $"{second} is larger than {first}";
			}

		}
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number...");
			int first = int.Parse(Console.ReadLine());
			Console.WriteLine("Please enter another number...");
			int second = int.Parse(Console.ReadLine());
			Console.WriteLine(compare(first, second));
		}
	}
}

