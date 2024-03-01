// Delegate can point to different methods and can be use to invloke that methods
// For pointing, the method should match the signature of the delegate
using System;

namespace DelegateApp
{
    public class Program
    {
        // Delegate declaration with a signature
        public delegate void MyDelegate(string msg);
        // This method can be pointed by our delegate
        public static void MethodA(string message)        
        {
            Console.WriteLine("Welcome, " + message);
        }
        public static void Main(string[] args)
        {
			// Set target method
            MyDelegate md = MethodA;     
			// Invoke delegate               			
            md("Ram");   			// Output: Welcome, Ram
        }
    }
}