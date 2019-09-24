using System;
namespace TriangleTracker.Models
{
    class Triangle
    {
        public int Side1;
        public int Side2;
        public int Side3;

        public Triangle(int side1, int side2, int side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public static string trackTriangle(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3 && side1 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                return "Scalene";
            }
            else
            {
                return "Not a triangle";
            }
        }
    }
}
