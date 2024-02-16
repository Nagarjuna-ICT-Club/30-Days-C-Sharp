using System;

namespace TypeCasting
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Implicit Casting: Happens automatically and no data is lost
      int n1 = 5;
      double n2 = n1;                 // Int -> Double
      Console.WriteLine(n2);          // Output: 5
      // Explicit Casting: Done manually and data is lost
      double n3 = 10.5;
      int n4 = (int) n3;              // Double -> Int
      Console.WriteLine(n4);          // Output: 10
      // String to Other Data-Type
      int num = int.Parse("100");
      Console.WriteLine(num);         // Output: 100
      // Other Data-Type to String
      string str1 = num.ToString();
      Console.WriteLine(str1);        // Output: 100
    }
  }
}