using System;

namespace PassRef
{
	public class Program
	{
		static void Modify(int i)
		{
			i = i + 5;
		}
		// Using 'ref'
		static void ModifyRef(ref int i)
		{
			i = i + 5;
		}
		
		public static void Main(string[] args)
		{
			int i = 10;
			Console.WriteLine("Before: i = " + i);          // Output: 10
			Modify(i);            // Pass by value   
			Console.WriteLine("After:  i = " + i);          // Output: 10
           
			Console.WriteLine("Before: i = " + i);          // Output: 10
			ModifyRef(ref i);    // Pass by reference
			Console.WriteLine("After:  i = " + i);          // Output: 15
		}
	}
}
