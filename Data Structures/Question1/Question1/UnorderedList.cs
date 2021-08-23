using System;
using System.Collections.Generic;
using System.Text;

namespace Question1
{
    public class UnorderedList<T>
    {
        internal Node<T> head;

        // Method to add at first position
        internal void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.next = this.head;
            this.head = node;
            //Console.WriteLine($"{node.data} is added to linked list");
        }

        // Method to append at last position
        internal void AddLast(T data)
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

        // Method to insert between the nodes
        internal void InsertAfter(Node<T> prev_node, T data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("Previous node cannot be empty");
                return;
            }
            Node<T> node = new Node<T>(data);
            node.next = prev_node.next;
            prev_node.next = node;
            //Console.WriteLine($"{node.data} is inserted into linked list");
        }


        // Method to delete node at first position
        internal void DeleteFirst()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                return;
            }
            this.head = temp.next;
            //Console.WriteLine("node is deleted from linked list");
        }

        // Method to delete node at first position
        internal void DeleteLast()
        {
            Node<T> temp = this.head;

            if (temp == null)
            {
                return;
            }

            if (temp.next == null)
            {
                return;
            }

            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            temp.next = null;
            //Console.WriteLine("node is deleted from linked list");
        }

        // Method to search if the value exits or not
        internal bool Search(T value)
        {
            Node<T> node = head;
            while (node != null)
            {
                if (node.data.Equals(value))
                {
                    return true;
                }
                node = node.next;
            }
            return false;
        }


        // Method to search if the value exits or not
        internal void Remove(T value)
        {
            Node<T> prev = null;
            Node<T> node = head;

            if (node != null && node.data.Equals(value))
            {
                head = node.next;
            }

            while (node != null && node.data.Equals(value))
            {
                prev = node;
                node = node.next;
            }

            if (node == null) { return; }

            prev.next = node.next;
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

        // Method to get value for the index
        internal T GetValue(int index)
        {
            Node<T> node = head;
            int count = 0;

            while (node != null)
            {
                if (count == index)
                {
                    return node.data;
                }
                count++;
                node = node.next;
            }
            return default(T);
        }
    }
}
