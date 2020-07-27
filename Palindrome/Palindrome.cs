using System;
using Reverse_String;


namespace Palindrome
{
    class Palindrome
    {
        public static bool isPalindrome(string inputString)
        {
            string reverseString = ReverseString.mirror(inputString);
            bool result;
            if (reverseString == inputString)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input a sting: ");
            string testString = Console.ReadLine();
            Console.WriteLine(isPalindrome(testString.ToLower()));
        }
    }
}
