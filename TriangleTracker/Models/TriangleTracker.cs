using System;
namespace TriangleTracker.Models
{
    class Triangle
    {
        public string IsTriangle(int side1, int side2, int side3)
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
