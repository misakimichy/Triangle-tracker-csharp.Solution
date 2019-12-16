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

      if (result == "Equilateral")
      {
        Console.WriteLine("It's equilater! All sides are equal.");
      }
      else if (result == "Isosceles")
      {
        Console.WriteLine("It's isosceles! Exactly 2 sides are equal.");
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