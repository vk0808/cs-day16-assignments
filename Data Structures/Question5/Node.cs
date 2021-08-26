using System;
using System.Collections.Generic;
using System.Text;

namespace Question5
{
	public class Node<T>
	{
		// Instance variable
		public T data;
		public Node<T> next;
		public Node<T> prev;

		// Constructor
		public Node(T val)
		{
			this.data = val;
			this.next = null;
			this.prev = null;
		}
	}
}
