using System;
// Exeption is a unexpected error occurred during runtime
// Technically, it is an Object in C# which is created on error
// If exception is not handled in C#, then program stops at the line of exceptions
// And runtime throws the exception
// Exceptions are derived from 'System.Exception' in C#
/*
    Bult-in System Exception Types:
    - IOException
    - DivideByZeroException
*/
namespace ExceptionHandlingApp
{
	public class Program{
		public static void CheckDivision(int a, int b){
			try{
				if (b == 0){
					throw new DivideByZeroException();			// Create and throw exception
				}
				else{
					Console.WriteLine("Division is: " + a / b);
				}
			}	
			catch (DivideByZeroException err){					// Catch the exception
				Console.WriteLine(err.Message);
			}
			finally{											// This runs anyway at last
				Console.WriteLine("Division Completed!");
			}
		}

		public static void Main(string[] args)
		{
			int a = 5;
			int b = 0;

			CheckDivision(a, b);
		}
	}
}