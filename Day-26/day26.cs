using System;
using System.IO;                    // 'File' class is located here

namespace FileHandling
{
	public class Program
	{
		public static void Main(string[] args)
		{
			string file1 = @"C:\Users\test1.txt";				// File path
			string file2 = @"C:\Users\test2.txt";
			string file3 = @"C:\Users\test3.txt";
			// Write File: File is created automatically if it doesn't exist
			File.WriteAllText(file1, "Ram\nShyam\nHari");
			File.WriteAllText(file2, "This is another file");
			// Read file 
			string result = File.ReadAllText(file1);
			Console.WriteLine(result);
			// Move the file to specified path and specify new name
			File.Move(file1, @"C:\Users\Public\test1.txt");
			// Copy the content of one file to another file
			File.Copy(file2, file3);
		}
	}
}
