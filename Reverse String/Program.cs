using System;

namespace Reverse_String
{
    class Program
    {
		// input string cat
		// return string tac
		public static string mirror(string normal)
		{
			string inputNormal = "";
			for (int i = normal.Length; i > 0;)
			{
				inputNormal += normal[--i];
			}
			return inputNormal;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("input your string.");
			string input = Console.ReadLine();
			Console.WriteLine(mirror(input));
		}
	}
}