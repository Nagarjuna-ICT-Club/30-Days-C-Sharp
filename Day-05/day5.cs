using System;

namespace StringMethod
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str1 = "Pineapple";
			string str2 = "Mango";

			Console.WriteLine(str1.Length);				// Output: 9
			Console.WriteLine(str1.Contains("apple"));	// Output: True
			// String Concatination.					   Output: Pineapple Fruit
			Console.WriteLine(str1 + " Fruit");				
			// Replaces Substrings with another. 		   Output: Pineapple Cake
			Console.WriteLine(str1.Replace("Fruit", "Cake"));
			// String Comparison
			Console.WriteLine(str1 == str2);		    // Output: False
			// Convert String Case
			Console.WriteLine(str1.ToUpper());			// Output: PINEAPPLE CAKE
			Console.WriteLine(str1.ToLower());			// Output: MANGO
			// Check if string is empty or not			   Output: False
			Console.WriteLine(String.IsNullOrEmpty(str1));
		}
	}
}