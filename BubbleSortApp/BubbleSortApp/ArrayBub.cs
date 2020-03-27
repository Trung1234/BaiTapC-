using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortApp
{
    public class ArrayBub
    {
        private long[] a; // ref to array a
        private int nElems; // number of data items
        // create constructor
        public ArrayBub(int max)
        {
            a = new long[max]; // create the array
            nElems = 0; // no item yet
        }
        public void Add(long value)
        {
            a[nElems] = value;
            nElems++;
        }
        public void Display()
        {
            for(int i = 0; i < nElems; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public int Size()
        {
            return nElems;
        }
        public void BubbleSort()
        {
            for(int i = nElems - 1; i > 1; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        //swap
                        long temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}
