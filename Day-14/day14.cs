using System;

 namespace InterfaceApp
{
	public interface IVehicle 			// It is a convention to start 'Interface' name with 'I'
	{
		//public IVehicle() { }			// Interface can't have contructor
		public void Start();			// In Interface, no need to specify methods as 'abstract'
		public void Stop();
	}
	public class Car : IVehicle			// Implementing 'Interface'
	{
		public void Start(){			// This class must implement 'Interface' methods
			Console.WriteLine("Car has been started!");
		}
		public void Stop(){
			Console.WriteLine("Car has stopped!");
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			//IVehicle v1 = new IVehicle();				// Can't instantiate from Interface

			Car c1 = new Car();							// 'Car' class implements 'IVehicle'
			c1.Start();
			c1.Stop();
		}
	}
}

// 'Interface' is a COMPLETE abstract class which is a blueprint for class. 
// It is like a contract/standard that needs to be satisfied during inheritance.
// To use 'Interface', class/struct should inherit the 'Interface'
// All the 'Interface' methods/properties should compulsorily be implemented in child class/struct

// NOTE: If multiple classes use same Interface, then all of them will have a common standard to communication with each other
// So, basically, there becomes an Interface for all the classes to communicate
// It only contains declaration of method/properties (It doesn't have fields cause field is implementation)