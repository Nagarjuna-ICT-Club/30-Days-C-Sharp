// Methods can either be: 'instance' (Default) or 'static'
using System;

namespace Methods
{
    public class MyClass
    {
        // Static Method
		public static void StaticMethod()
		{
			Console.WriteLine("I am Static Method!");
		}
		// Instance Method
		public void InstanceMethod()
		{
			Console.WriteLine("I am Instance Method!");
		}
    }
	public class Program
	{
		public static void Main(string[] args)
		{
			// Invoking 'static' method directly through Class Name
			MyClass.StaticMethod();
            
			// Invoking 'instance' method by creating Object Instance
			MyClass obj1 = new MyClass();
			obj1.InstanceMethod();
		}
	}
}