// Generic Method can have parameters whose unknown type
// It is more efficient than using 'var' or 'object' parameter
using System;

namespace GenericsApp
{
	public class MyClass
	{
		// Generic method where 'T' and 'Z' are unknown data types
		public void ShowValue<T, Z>(T value1, Z value2)
		{
			Console.WriteLine($"{value1} and {value2}");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			MyClass m1 = new MyClass();
			// Strictly specifying parameter type for type safety
			m1.ShowValue<int, int>(5, 6);								// Output: 5 and 6
			m1.ShowValue<float, int>(10.5f, 20);                        // Output: 10.5 and 20
			m1.ShowValue<int, string>(100, "Rupees");					// Output: 100 and Rupees
		}
	}
}