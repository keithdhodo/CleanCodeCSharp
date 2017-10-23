using Chapter06.Interfaces;
using Chapter06.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Chapter06Tests
{
    [TestClass]
    public class RectangleTests
    {
        public IShape Rectangle { get; set; }

        [TestMethod]
        public void Rectangle_TestGettingArea()
        {
            var topLeft = new Point();
            topLeft.SetCartesian(3, 3);
            Rectangle = new Rectangle(topLeft, 4, 4);

            var expected = Math.Round(16.0, 4);
            Assert.AreEqual(expected, Math.Round(Rectangle.Area(), 4));
        }
    }
}
