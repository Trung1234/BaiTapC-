using System;

namespace LastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = lastDigitRegExp("3w2");
            Console.WriteLine("result: "+result.ToString());
            Console.ReadLine();
        }
        static char lastDigitRegExp(string inputString)
        {
            char result = '\0';
            foreach (char c in inputString)
            {             
                if (Char.IsNumber(c))
                {
                    result = c;
                }
            }
            return result;
        }

    }
}
