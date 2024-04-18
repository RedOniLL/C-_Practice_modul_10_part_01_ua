using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_10_part_01_ua
{
    public class MyStack<T>
    {
        private T[] elements;
        private bool[] active;
        private int top;

        public int Count { get { return top + 1; } }

        public MyStack(int capacity)
        {
            elements = new T[capacity];
            active = new bool[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            elements[++top] = item;
            active[top] = true;
        }

        public T Pop()
        {
 
            T poppedItem = elements[top];
            active[top] = false;
            top--;
            return poppedItem;
        }

        public T Peek()
        {
            return elements[top];
        }
    }
}
