using System;

namespace Methods
{
    public class MyClass
    {
		public static void StaticMethod(){
			Console.WriteLine("I am Static");
		}
		public void InstanceMethod(){
			Console.WriteLine("I am Instance");
		}
    }
	public class Program
	{
		public static void Main(string[] args)
		{
			// Invoking 'static' method directly through Class Name
			MyClass.StaticMethod();				// Output: I am Static
            
			// Invoking 'instance' method by creating Object Instance
			MyClass obj1 = new MyClass();		// Output: I am Instane
			obj1.InstanceMethod();
		}
	}
}