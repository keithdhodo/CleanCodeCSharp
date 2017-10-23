using Chapter06.Interfaces;
using Chapter06.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06Tests
{
    public class SquareTests
    {
        [TestClass]
        public class RectangleTests
        {
            public IShape Square { get; set; }

            [TestMethod]
            public void Square_TestGettingArea()
            {
                var center = new Chapter06.Models.Point();
                center.SetCartesian(3, 3);
                Square = new Square(center, 4);

                var expected = Math.Round(16.0, 4);
                Assert.AreEqual(expected, Math.Round(Square.Area(), 4));
            }
        }
    }
}
