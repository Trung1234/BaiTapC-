using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArrayList
{
    public class MyArrayList : IArrayList
    {
        private long[] a; // ref to array a

        public int Count { get; private set; }
        // create constructor
        public MyArrayList(int max)
        {
            a = new long[max]; // create the array
            Count = 0; // no item yet
        }

        public void AddFirst(long value)
        {
            Count++;
            // move higher ones down
            for (int k = Count - 1; k > 0; k--)
                a[k] = a[k - 1];
            a[0] = value;
        }
        public void Add(long value)
        {
            a[Count] = value;
            Count++;
        }
        public void Add(int index,long value)
        {
            Count++; // increment size
            // move higher ones down
            for (int k = Count-1; k >= index; k--)
                a[k+1] = a[k];          
            a[index] = value;           
        }

        public bool Delete(long value)
        {
            int j;
            // look for it
            for (j = 0; j < Count; j++)
                if (a[j] == value)
                    break;
            if (j == Count)
                return false;
            else // found it
            {
                // move higher ones down
                for (int k = j; k < Count; k++)
                    a[k] = a[k + 1];
                Count--; // decrement size
                return true;
            }
        }
        public bool Contains(long searchKey)
        {
            int j;
            for (j = 0; j < Count; j++)
                if (a[j] == searchKey)
                    break;
            if (j == Count)
                return false;
            else
                return true;
        }
        public void Display()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public void BubbleSort()
        {
            for (int i = Count - 1; i > 1; i--)
            {
                for (int j = 0; j < i; j++)
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


        public void Clear()
        {
            Count = 0;
        }

        public void Reverse()
        {
            for (int i = 0; i < Count / 2; i++)
            {
                long tmp = a[i];
                a[i] = a[Count - i - 1];
                a[Count - i - 1] = tmp;
            }
        }
    }
}
