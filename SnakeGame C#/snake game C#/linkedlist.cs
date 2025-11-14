/*
 * Created by SharpDevelop.
 * User: garnett
 * Date: 21.11.2010
 * Time: 21:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Snake
{
	/// <summary>
	/// Description of linkedlist.
	/// </summary>

	public class Node: IDisposable
	{
		public Node(int number)
		{
			value = number;
			previous = null;
			next = null;
		}
		
		public void Dispose() {
			
			GC.SuppressFinalize(this);
			
		}
		
		
		public int value;
		public Node previous;
		public Node next;
		
		
	}
	
	public class Linkedlist
	{
		public Linkedlist()
		{
			length = 0;
		}
		
		public Node last;
		public Node first;
		public int length;
		
		
		
		public void Add_Node(int number)
		{
			if(last == null)
			{
				Node nd = new Node(number);
				last = nd;
				last.next = null;
				last.previous = null;
				first = last;
			}
			else
			{
				Node nd = new Node(number);
				last.next = nd;
				nd.previous = last;
				nd.next = null;
				last = nd;
			}
			length++;
		}
		
		public int Get_The_Last_Node_Value()
		{
			return last.value;
		}
		
		public int Get_The_First_Node_Value()
		{
			return first.value;
		}
		
		public void Delete_First_Node()
		{
			if(first!=last) {
				Node temp = first;
				first = first.next;
				first.previous = null;
				temp.Dispose();
				length--;
			}
		}
	}
}
