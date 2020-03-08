using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {          
            int reverseNumber = reverseInteger(340566);
            Console.WriteLine("reversed Number of 340566 is {0}", reverseNumber);
            reverseNumber = reverseInteger(-100607);
            Console.WriteLine("reversed Number of -100607 is {0}", reverseNumber);
            reverseNumber = reverseInteger(10020);
            Console.WriteLine("reversed Number of 10020 is {0}", reverseNumber);
            Console.ReadLine();
        }
        static int reverseInteger(int num)
        {
            int  reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }
            return reversed;
        }
    }
}
