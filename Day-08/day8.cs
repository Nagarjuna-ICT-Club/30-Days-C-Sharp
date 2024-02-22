using System;

namespace ClassObject
{
	public class Animal							// Custom Class
	{
		public string name = "No Name";			// Member variable
		// Constructor Function runs automatically when object is created
		public Animal(){}						// Default Constructor			
		public Animal(string n){				// Constructor with parameter
			name = n;
		}
		public void ShowInfo(){					// Member function
			Console.WriteLine("Name of animal: " + name);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Animal dog = new Animal("Lucy");		// Object creation
			// Name of animal: Lucy
			dog.ShowInfo();							// Accessing object method
		}
	}
}