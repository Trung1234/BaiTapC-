
using System;

namespace BubbleSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBub data = new ArrayBub(100);
            data.Add(20);
            data.Add(40);
            data.Add(30);
            data.Add(4);
            data.Add(5);
            data.Add(25);
            Console.WriteLine("Array before sort!");
            data.Display();
            data.BubbleSort();
            Console.WriteLine("Array after sort!");
            data.Display();
            Console.ReadLine();
        }
    }
}
