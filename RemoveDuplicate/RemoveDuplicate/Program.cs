using System;
using System.Collections.Generic;

namespace RemoveDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrays = new List<int> { 1, 2,4, 2, 3, 6,3, 7, 8,9, 5, 9, 12 };
            List<int> newArrays = new List<int>();
            newArrays[0] = arrays[0];
            foreach(var item in arrays)
            {
                if (!newArrays.Contains(item))
                {
                    newArrays.Add(item);
                }
            }
            foreach (var item in arrays)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
