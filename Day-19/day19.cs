using System;
using System.Collections;

namespace StackApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack s = new Stack();                  
			s.Push(1);                              		// Insert item in stack
			s.Push(2);
			s.Push(3);
			// 'Contains()' checks if stack has specified item or not
			Console.WriteLine(s.Contains(1));     			// Output: True
			Console.WriteLine(s.Count);
			// 'Pop()' returns last item and removes it from stack
			Console.WriteLine(s.Pop());						// Output: 3
			// 'Peek()' returns last item but doesn't remove it from stack
			Console.WriteLine(s.Peek());					// Output: 2
			// Stack Traversal happens from last to first
			foreach (object obj in s){
				Console.WriteLine(obj);
			}
		}
	}
}