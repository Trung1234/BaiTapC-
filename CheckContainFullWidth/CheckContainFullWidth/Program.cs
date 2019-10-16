using System;
using System.Text;

namespace CheckContainFullWidth
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Trung1238456はい";
            Console.WriteLine(IsContainFullWidth(test));
            Console.ReadLine();
        }
        public static bool IsContainFullWidth(string input)
        {          
            bool isFullWidth = false;
            foreach (var c in input.ToCharArray())
            {
                if (!isHalfWidth(c))
                {
                    isFullWidth = true;
                    break;
                }
            }
            return isFullWidth;
        }

        private static bool isHalfWidth(char c)
        {
            return '\u0000' <= c && c <= '\u00FF'
        || '\uFF61' <= c && c <= '\uFFDC'
        || '\uFFE8' <= c && c <= '\uFFEE';
        }
    }
}
