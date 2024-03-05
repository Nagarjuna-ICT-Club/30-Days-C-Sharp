using System;
using System.Collections;

namespace QueueApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Queue q = new Queue();         
			q.Enqueue(1);											// Insert items into the Queue
			q.Enqueue(2);
			q.Enqueue(3);
			// 'Contains()' checks if queue has specified item or not
			Console.WriteLine(q.Contains(2)); 						// Output: True
			Console.WriteLine(q.Count);          					// Output: 3
			// 'Dequeue' returns first item and removes it from queue
			Console.WriteLine(q.Dequeue());							// Output: 1
			// 'Peek' returns first item but doesn't remove it from queue
			Console.WriteLine(q.Peek());							// Output: 2
			// Queue traversal is similar to Array Traversal
			foreach (object obj in q){
				Console.WriteLine(obj);
			}
		}
	}
}