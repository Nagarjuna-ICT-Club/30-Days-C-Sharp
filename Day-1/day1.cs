 using System;					// Allows 'System' Namespace

namespace HelloWorld			// Defining custom Namespace
{
    public class MyProgram		// Function should be inside a Class
    {
        // 'static' keyword allows running method without creating Object 
        static void Main()
        {
            // 'System' has 'Console' class which has 'WriteLine()' method 
            Console.WriteLine("Hello World");
        }
    }
}