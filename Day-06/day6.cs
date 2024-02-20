using System;

namespace ArrayApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Array Declaration with 'new' keyword
			int[] array1 = new int[3];			
			Console.WriteLine(array1.Length);				// Output: 3	
			// Array Definition with index number
			array1[0] = 1;
			array1[1] = 2;
			array1[2] = 3;

			// 2D Array Declaration and Definition 
			int[,] array2 = {{1, 2, 3}, {4, 5, 6}};
			foreach(int element in array2)					// Output: 1, 2, 3, 4, 5, 6
			{
				Console.Write("{0}\t", element);
			}
		}
	}
}
