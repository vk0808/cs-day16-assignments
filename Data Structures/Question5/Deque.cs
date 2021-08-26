using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
	public class Deque<T>
	{
		Node<T> front;
		Node<T> rear;
		int size = 0;

		// Method to add front
		internal void AddFront(T value)
		{
			if (front == null) // if there is no element in deque
			{
				front.data = value;
				rear = front;
			}
			else  // if there is element in deque
			{
				Node<T> tNode = null;
				tNode.data = value;
				tNode.next = front;
				front.prev = tNode;
				front = tNode;
			}
			size++;
		}

		// Method to add rear
		internal void AddRear(T value)
		{
			if (front == null) // if there is no element in deque
			{
				Node<T> tNode = new Node<T>(value);
				front = tNode;
				rear = front;
			}
			else  // if there is element in deque
			{
				Node<T> tNode = new Node<T>(value);
				rear.next = tNode;
				tNode.prev = rear;
				rear = tNode;
			}
			size++;
		}

		// Method to remove front
		internal T RemoveFront()
		{
			T val = default(T);
			if (front == null)
			{
                Console.WriteLine("No elements to delete");
			}
			else
			{
				val = front.data;
				front = front.next;
			}
			size--;
			return val;
		}

		// Method to remove rear
		internal T RemoveRear()
		{
			T val = default(T);
			if (front == null)
			{
				Console.WriteLine("No element to delete");
			}
			else
			{
				val = rear.data;
				rear = rear.prev;
				rear.next = null;
			}
			size--;
			return val;
		}

		// Method to to remove
		internal bool isEmpty()
		{
			if (front == null)
				return true;
			else
				return false;
		}

		// Method to return size of deque
		internal int Size()
		{
			return size;
		}
	}
}
