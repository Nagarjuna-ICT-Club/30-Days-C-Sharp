using System;

namespace DateTimeProgram
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// 'DateTime' is a structure used to represent a single point of time
			DateTime defaultDate = new DateTime();
			Console.WriteLine(defaultDate);		// Output: 1/1/0001 12:00:00 AM	

			// Specifying custom date in Year/Month/Day format
			DateTime customDate = new DateTime(2023, 12, 24);
			Console.WriteLine(customDate);		// Output: 12/24/2023 12:00:00 AM

			// DateTime instance Fields
			Console.WriteLine(customDate.Day);				// Output: 24
			Console.WriteLine(customDate.Month);			// Output: 12
			Console.WriteLine(customDate.Year);				// Output: 2023

			// String to DateTime conversion	// Output: 6/25/2022 12:00:00 AM	
			Console.WriteLine(DateTime.Parse("2022/06/25"));
		}
	}
}