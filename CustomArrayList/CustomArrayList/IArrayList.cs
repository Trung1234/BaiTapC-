using System;
using System.Collections.Generic;
using System.Text;

namespace CustomArrayList
{
    public interface IArrayList
    {
        void Add(long value);
        void AddFirst(long value);
        void Add(int index, long value);
        void Reverse();
        void Clear();
        bool Delete(long value);
        bool Contains(long searchKey);
        void BubbleSort();
        void Display();
    }
}
