using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
	public class Node<T>
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
	}
}
