using System;

namespace TimeSpanProgram
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // 'TimeSpan' is used to represent a period of time
      TimeSpan defaultTime = new TimeSpan();              // Output: 00:00:00
      Console.WriteLine(defaultTime);

      // Specifying custom time period in Hour/Minute/Second format
      TimeSpan customTime = new TimeSpan(03, 25, 45);
      Console.WriteLine(customTime);                      // Output: 03:25:45

      // TimeSpan fields
      Console.WriteLine(customTime.Hours);                // Output: 3
      Console.WriteLine(customTime.Minutes);              // Output: 25
      Console.WriteLine(customTime.Seconds);              // Output: 45

      // String to TimeSpan conversion                   // Output: 03:25:45
      Console.WriteLine(TimeSpan.Parse("03:25:45"));
    }
  }
}