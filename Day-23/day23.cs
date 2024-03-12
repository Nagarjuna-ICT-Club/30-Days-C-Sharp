using System;
using System.Collections.Generic;
// Generic Stack is type safe and it prevents accidental type mismatch

namespace GenericStackApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Stack<int> s = new Stack<int>();       			// Generic Stack storing integer
			s.Push(1);                              		// Insert item in stack
			s.Push(2);
			s.Push(3);
			//s.Push("Hello");								// This will give syntac error

			Console.WriteLine(s.Contains(1));     			// Output: True
			Console.WriteLine(s.Count);						// Output: 3
			// 'Pop()' returns last item and removes it from stack
			Console.WriteLine(s.Pop());						// Output: 3
			// 'Peek()' returns last item but doesn't remove it from stack
			Console.WriteLine(s.Peek());					// Output: 2

			// Stack Traversal same as Array Traversal, but prints from last
			foreach (int elem in s)
			{
				Console.WriteLine(elem);
			}
		}
	}
}