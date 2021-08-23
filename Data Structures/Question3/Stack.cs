using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    public class Stack<T>
    {
        private int top;
        private T[] stack;
        private int maxSize;

        public Stack(int size)
        {
            this.maxSize = size;
            this.stack = new T[maxSize];
            this.top = -1;
        }

        internal void push(T data)
        {
            if (top == this.maxSize)
            {
                Console.WriteLine("Stack full");
            }
            else
            {
                stack[++top] = data;
            }
        }

        internal T pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                T element = stack[top];
                top--;
                return element;
            }
        }

        internal T peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return default(T);
            }
            else
            {
                return stack[top];
            }
        }


        internal bool isEmpty()
        {
            return (top == -1) ? true : false;
        }

        internal int size()
        {
            return top + 1;
        }
    }
}
