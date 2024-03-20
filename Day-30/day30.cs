using System;
using System.Threading.Tasks;									// Allows Asynchronous Operations

namespace AsyncAwaitApp
{
	public class Program
	{
		public static async Task MethodA()						// Asynchronous Method
		{
			await Task.Run(() => {								// Delayed Task
				for (int i = 0; i < 100; i++)
				{
					Console.WriteLine("Method A");
				}
			});
		}
		public static void MethodB()							// Synchronous Method
		{
			for (int i = 0; i < 20; i++)
			{
				Console.WriteLine("Method B");
			}
		}
		static void Main(string[] args)
		{
			// MethodA() runs in background and MethodB() runs in foreground 
			MethodA();											// Invoke Asynchronous Method
			MethodB();											// Invoke Synchronous Method
		}
	}
}