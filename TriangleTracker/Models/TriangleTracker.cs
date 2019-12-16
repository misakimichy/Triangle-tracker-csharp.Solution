using System;
namespace TriangleTracker.Models
{
    class Triangle
    {
        public string IsTriangle(int side1, int side2, int side3)
        {
            if (side1 > (side2 + side3) || side2 > (side1 + side3)|| side3 > (side1 + side2))
            {
                return "not a triangle";
            }
            else if (side1 == side2 && side2 == side3)
            {
                return "equilateral";
            }
            else if (side1 != side2 && side1 != side3 && side2 != side3)
            {
                return "scalene";
            }
            else
            {
                return "ssosceles";
            }
        }
    }
}
