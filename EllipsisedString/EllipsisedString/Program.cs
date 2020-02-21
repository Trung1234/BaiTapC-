using System;

namespace EllipsisedString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a very long string and I want to cut it with ellipsis!".TruncateAtWord(10));
        }
        
    }
}
