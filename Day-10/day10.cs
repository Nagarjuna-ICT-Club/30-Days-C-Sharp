using System;

namespace Inheritance
{
	public class Animal{
		public string name;		
		public void ShowName(){
			Console.WriteLine("Animal name is " + name);
		}
	}
	public class Dog : Animal			// 'Dog' will have features of 'Animal' class
	{
		public string sound;
		public void Showsound(){
			Console.WriteLine("Animal sound is " + sound);
		}
	}
	public class Program{
		public static void Main(string[] args){
			Animal v1 = new Animal();			// Parent object creation
			v1.name = "Mammal";
			v1.ShowName();				// Output: Animal name is Mammal

			Dog c1 = new Dog();					// Child object creation
			c1.name = "Lucy";			// Feature inherited from 'Animal'
			c1.sound = "Woof";
			c1.ShowName();				// Output: Animal name is Lucy
			c1.Showsound();				// Output: Animal sound is Woof
		}
	}
}