// If a class is 'abstract' then it means, 
// It is incomplete and some methods needs to be implemented by child classes to be complete
// Abstract can't be insatnciated but can have contructor for setting variables 
// It is only supposed to be a base class for other classes to inherit it

using System;

namespace AbstractClassApp
{
	public abstract class Vehicle		// Abstract Class must have atleast 1 abstract method 
	{
		public string name;
		public Vehicle(string n){
			name = n;
		}
		public abstract void ShowInfo();		// Abstract methods should only be declared
	}
	public class Car : Vehicle
	{
		public double speed;
		public Car(string n, double s) : base(n){
			speed = s;
		}
		public override void ShowInfo(){		// Overwriding abstract method of parent class
			Console.WriteLine("Car Name: " +  name);
			Console.WriteLine("Car Speed: " + speed);
		}
	}
	public class Program
	{
		public static void Main(string[] args){
			//Vehicle v1 = new Vehicle("Jeep", 380);	// Abstract Class can't be instantiated
			Car c1 = new Car("BMW", 400);
			c1.ShowInfo();
		}
	}
}
