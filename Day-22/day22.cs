using System;
using System.Collections.Generic;

// Generic Queue is type safe and it prevents accidental type mismatch 
namespace GenericQueueApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue<int> q = new Queue<int>();       // Generic 'Queue' storing integer data
			q.Enqueue(1);						   // Insert items into the Queue
			q.Enqueue(2);
			q.Enqueue(3);
			//q.Enqueue("Hello");						// This is not allowed 

			Console.WriteLine(q.Contains(2)); 			// Output: True
			Console.WriteLine(q.Count);         		// Output: 3
			// 'Dequeue' returns first item and removes it from queue
			Console.WriteLine(q.Dequeue());				// Output: 1
			// 'Peek' returns first item but doesn't remove it from generic queue
			Console.WriteLine(q.Peek());				// Output: 2

			// Generic Queue traversal is similar to Array Traversal
			foreach (object obj in q)
			{
				Console.WriteLine(obj);
			}
		}
	}
}