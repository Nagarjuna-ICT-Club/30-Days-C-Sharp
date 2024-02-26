using System;
// Method Overriding allows child to re-define the same method that in parent class 
namespace ClassObject
{
	public class Parent								// Parent Class
	{
		public void ShowInfo(){				
			Console.WriteLine("This is Parent");
		}
	}
	public class Child : Parent						// Child Class
	{
		public new void ShowInfo(){					// New Method
			Console.WriteLine("This is Child");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Parent p1 = new Parent();		
			// Parent's method gets executed
			p1.ShowInfo();							// Output: This is Parent							

			Child c1 = new Child();		
			// Child's method gets executed
			c1.ShowInfo();							// Output: This is Child		
		}
	}
}