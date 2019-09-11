using System;

namespace L2_Algorithms_DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      // Array examples
      // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

      int[] ExampleArray = new int[5];
      ExampleArray[0] = 0;
      ExampleArray[1] = 1;

      Console.WriteLine(ExampleArray[0]);
      Console.WriteLine(ExampleArray[1]);
      Console.WriteLine(ExampleArray[2]); // what to expect here?

      //Alternate forms of initialization
      string[] weekDays1 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
      string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

      // Exercise: print the element with content "Thu"
    }
  }
}
