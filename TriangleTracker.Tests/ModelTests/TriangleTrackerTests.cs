using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace Program.Tests
{
    [TestClass]
    public class TriangleTrackerTest
    {
        [TestMethod]
        public void IsTriangle_IsNotATriangle_NotATriangle()
        {
            Triangle testNot = new Triangle();
            Assert.AreEqual("not a triangle", testNot.IsTriangle(3, 3, 6));
        }

        [TestMethod]
        public void IsTriangle_IsEquilateral_Equilateral()
        {
            Triangle testEquilateral = new Triangle();
            Assert.AreEqual("equilateral", testEquilateral.IsTriangle(5, 5, 5));
        }

        [TestMethod]
        public void IsTriangle_IsScalene_Scalene()
        {
            Triangle testScalene = new Triangle();
            Assert.AreEqual("scalene", testScalene.IsTriangle(3, 4, 5));
        }

        [TestMethod]
        public void IsTriangle_IsIsosceles_Isosceles()
        {
            Triangle testIsosceles = new Triangle();
            Assert.AreEqual("isosceles", testIsosceles.IsTriangle(8, 8, 5));
        }
    }
}