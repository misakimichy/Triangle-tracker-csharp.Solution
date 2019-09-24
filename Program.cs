using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Make a triangle!");
      Console.WriteLine("Please enter the number for side 1");
      string input1 = Console.ReadLine();
      int side1 = int.Parse(input1);

      Console.WriteLine("Please enter the number for side 2");
      string input2 = Console.ReadLine();
      int side2 = int.Parse(input2);

      Console.WriteLine("Please enter the number for side 3");
      string input3 = Console.ReadLine();
      int side3 = int.Parse(input3);
      
      string result = Triangle.trackTriangle(side1, side2, side3);

      if (result == "Equilateral")
      {
        Console.WriteLine("It's equilater! All sides are equal.");
      }
      else if (result == "Isosceles")
      {
        Console.WriteLine("It's isosceles!. Exactly 2 sides are equal.");
      }
      else if (result == "Scalene")
      {
        Console.WriteLine("It's scalene! No isdes are equal.");
      }
      else if (result == "Not a triangle")
      {
        Console.WriteLine("This is not a triangle!");
      }
    }
  }
}