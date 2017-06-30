using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunction
{
    class Stack<T>
    {
        public T[] t;
        protected int pointer;
        readonly int size;

        public Stack(int capacity)
        {
            t = new T[capacity];
            size = capacity;
            pointer = 0;
        }
        public void Push(T item)
        {
            if (pointer >= size)
            {
                throw (new StackOverflowException("Tele van..."));
            }
            t[pointer++] = item;
        }

        public T Pop()
        {
            if(pointer-- >= 0)
            {
                T output = t[pointer];
                return output;
            }
            pointer = 0;
            throw (new InvalidOperationException("Üres..."));
        }
        
    }
}
