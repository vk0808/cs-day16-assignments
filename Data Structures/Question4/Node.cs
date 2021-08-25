using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    class Node<T>
	{
		// instance variables
		public T data;
		public Node<T> next;

		// constructor
		public Node(T data)
		{
			this.data = (T)data;
			this.next = null;
		}

		// method that return data of a given node
		public T Getdata()
		{
			return data;
		}

		// method that gets the next node
		public Node<T> GetNext()
		{
			return next;
		}

		// method to set data in node
		public void SetData(T newData)
		{
			this.data = newData;
		}

		// method to set next in node
		public void SetNext(Node<T> newNext)
		{
			this.next = newNext;
		}
	}
}
