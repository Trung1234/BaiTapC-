using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortApp
{
    public class ArrayBub
    {
        
        private long[] a; // ref to array a
        private int nElems; // number of data items
        public int Count 
        {
            get
            {
                return nElems;
            }
        }
        // create constructor
        public ArrayBub(int max)
        {
            a = new long[max]; // create the array
            nElems = 0; // no item yet
        }

        public void AddFirst(long value)
        {          
            nElems++;
            // move higher ones down
            for (int k = nElems-1; k >0; k--)
                a[k] = a[k-1];
            a[0] = value;
        }
        public void Add(long value)
        {
            a[nElems] = value;
            nElems++;
        }

        public bool Delete(long value)
        {
            int j;
            // look for it
            for (j = 0; j < nElems; j++)
                if (a[j] == value)
                    break;
            if (j == nElems)
                return false;
            else // found it
            {
                // move higher ones down
                for (int k = j; k < nElems; k++)
                    a[k] = a[k + 1];
                nElems--; // decrement size
                return true;
            }
        }
        public bool Contains(long searchKey)
        {
            int j;
            for (j = 0; j < nElems; j++)
                if (a[j] == searchKey)
                    break;
            if (j == nElems)
                return false;
            else
                return true;
        }
        public void Display()
        {
            for(int i = 0; i < nElems; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
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
