using System;
// Event is any action/activity that is recognized and can be handled by the program. 
// For example: Button Click, Key Press, Mouse Movement, etc.
// Event in C# follows Publisher-Subscriber model
// Publisher is the class/object that creates and emits the event
// Subscriber is the class/object listens to the event and handles it

namespace EventApp
{
	public delegate void MyEventHandler(string str);
	public class Publisher{
		public event MyEventHandler OnValueAssign;				// Declaring Event
		public string name;
		public void SetName(string value){
			name = value;
			if (OnValueAssign != null) OnValueAssign(name);     // Emits Event if handler exists
			else Console.WriteLine("No Event Handler!");
		}
	}
	public class Subscriber{
		// Emitted event is handled by this method
		public void ShowUpdate(string str)						// Event Handler 
		{
			Console.WriteLine("Updated value is " + str);
		}
	}
	public class Program{
		public static void Main(string[] args){
			string input = "Ram";					

			Publisher p1 = new Publisher();						// Event publisher object
			Subscriber s1 = new Subscriber();                   // Event Subscriber object

			// Event is not emitted until an event handler is added
			p1.SetName(input);									// Output: No Event Handler!	

			// Adding subscriber's event handler to the publisher's event
			p1.OnValueAssign += s1.ShowUpdate;					
			p1.SetName(input);									// Output: Updated value is Ram
		}
	}
}
