using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {          
            int reverseNumber = reverseInteger(34566);
            Console.WriteLine("reversed Number of 34566 is {0}", reverseNumber);
            reverseNumber = reverseInteger(-10607);
            Console.WriteLine("reversed Number of -10607 is {0}", reverseNumber);
            reverseNumber = reverseInteger(1020);
            Console.WriteLine("reversed Number of 1020 is {0}", reverseNumber);
            Console.ReadLine();
        }
        static int reverseInteger(int x)
        {
            int result = 0;
            while (x % 10 == 0)
            {
                x = x / 10;
            }
            if(x % 10 != 0)
            {
                while (x % 10 != 0)
                {
                    int n = x % 10;
                    int length = (int) Math.Abs(x).ToString().Length;
                    result += n * (int)Math.Pow(10, length - 1);
                    x = x / 10;
                    if(length > 1 && x % 10 == 0)
                    {
                        x = x / 10;
                    }
                }
            }          
            return result;
        }
    }
}
