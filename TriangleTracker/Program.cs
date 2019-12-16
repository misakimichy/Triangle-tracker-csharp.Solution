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
      int side1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Please enter the number for side 2");
      int side2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Please enter the number for side 3");
      int side3 = int.Parse(Console.ReadLine());
      
      Triangle inputTriangle = new Triangle();
      string result = inputTriangle.IsTriangle(side1, side2, side3);

      Console.WriteLine($"This is {result}.");
    }
  }
}