using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    class Queue<T>
    {
        internal Node<T> head;

        
        // Method to append at last position
        internal void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Console.WriteLine($"{node.data} is appended to linked list");
        }


        // Method to delete node at first position
        internal void Dequeue()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                return;
            }
            this.head = temp.next;
            //Console.WriteLine("node is deleted from linked list");
        }


        // Method to display
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "\n");
                temp = temp.next;
            }
        }

        // Method to get size
        internal int Count()
        {
            int count = 0;
            Node<T> node = this.head;
            if (node == null)
            {
                return count;
            }
            while (node != null)
            {
                node = node.next;
                count++;
            }
            return count;
        }


        // Method to check if queue is Empty
        internal bool isEmpty()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                return true;
            }
            return false;
        }
    }
}
