using System;

namespace Properties
{
	public class Circle
	{
		private double _Radius;					// Can't access private variable direcctly
		// Property
		public double Radius					// 'Radius' refers to '_Radius'
		{
			get{								// 'get' accessor
				return _Radius;
			}
			set{								// 'set' accessor 
				if (value > 0) _Radius = value;
				else _Radius = 0;
			}
		}
		public class Program
		{
			public static void Main(string[] args)
			{
				Circle c = new Circle();
				// 'set' accessor automatically runs while assigning property
				c.Radius = 6.57;                // 6.57 is the 'value' for 'set'
				// 'get' accessor automatically runs while accesing property
				Console.WriteLine("Circle radius property is: " + c.Radius);
			}
		}
	}
}