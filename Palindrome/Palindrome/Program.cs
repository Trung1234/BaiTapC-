using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstr;
            Console.Write("Enter a string : ");
            inputstr = Console.ReadLine();
            if (inputstr != null)
            {
                if (checkPalindrome(inputstr))
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }
            }
        }
        private static bool checkPalindrome(string inputString)
        {

            int n = inputString.Length;
            string reversed = string.Empty;
            if (n <= 1)
            {
                return true;
            }
            else
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    reversed += inputString[i];
                }
                if (reversed.Equals(inputString))
                {
                    return true;
                }
                return false;
            }

        }
    }
}
