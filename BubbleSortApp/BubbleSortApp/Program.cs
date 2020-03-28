
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
            Console.WriteLine("Size of array: {0}", data.Count);
            data.Display();
            data.BubbleSort();
            Console.WriteLine("Array after sort!");
            Console.WriteLine("Size of array: {0}", data.Count);
            data.Display();
            Console.WriteLine("Array after Add first!");
            
            data.AddFirst(100);
            data.Display();
            Console.WriteLine("Size of array: {0}", data.Count);
            Console.ReadLine();
        }
    }
}
