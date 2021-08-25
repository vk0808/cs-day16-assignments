using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    public class Stack<T>
    {
        // Instance variable
        private int top;
        private T[] stack;
        private int maxSize;

        // Constructor
        public Stack(int size)
        {
            this.maxSize = size;
            this.stack = new T[maxSize];
            this.top = -1;
        }

        // Method to Push to stack
        internal void Push(T data)
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

        // Method to Pop from stack
        internal T Pop()
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

        // Method to Peek at stack
        internal T Peek()
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

        // Method to check is stack Empty
        internal bool isEmpty()
        {
            return (top == -1) ? true : false;
        }

        // Method to find stack Size
        internal int Size()
        {
            return top + 1;
        }
    }
}
