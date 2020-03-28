using System;

namespace CustomArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList data = new MyArrayList(100);
            data.Add(20);
            data.Add(40);
            data.Add(30);
            data.Add(4);
            data.Add(15);
            data.Add(5);
            data.Add(25);
            Console.WriteLine("Size of array: {0}", data.Count);
            Console.WriteLine("Array before sort!");           
            data.Display();
            data.BubbleSort();
            Console.WriteLine("Array after sort!");
            Console.WriteLine("Size of array: {0}", data.Count);
            data.Display();
            Console.WriteLine("Array after Add first!");
            data.AddFirst(100);
            data.Display();
            Console.WriteLine("Size of array: {0}", data.Count);
            Console.WriteLine("Array after Add item to index of 2!");
            data.Add(2, 1000);
            data.Display();

            //check is contain 4
            long searchKey = 4;
            if(data.Contains(searchKey))
                Console.WriteLine("Array contain {0} !",searchKey);
            else
                Console.WriteLine("Array does not contain {0}", searchKey);

            data.Reverse();
            Console.WriteLine("Array after Reverse!");
            data.Display();

            data.Clear();
            Console.WriteLine("Size of array after reset: {0}", data.Count);
            Console.ReadLine();
        }
    }
}
