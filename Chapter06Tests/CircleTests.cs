using Chapter06.Interfaces;
using Chapter06.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Chapter06Tests
{
    [TestClass]
    public class CircleTests
    {
        public IShape Circle { get; set; }

        [TestMethod]
        public void Circle_TestGettingArea()
        {
            var center = new Point();
            center.SetCartesian(3, 3);
            Circle = new Circle(center, 4);

            var expected = Math.Round(50.2654824574367, 4);
            Assert.AreEqual(expected, Math.Round(Circle.Area(), 4));
        }
    }
}
