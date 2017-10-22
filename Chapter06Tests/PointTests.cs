using Chapter06;
using Chapter06.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter06Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void ConcretePoint_TestThatXAndYCanBeSet()
        {
            IPoint point = new Chapter06.Models.Point();
            point.SetCartesian(5, 6);

            Assert.AreEqual(5, point.X);
            Assert.AreEqual(6, point.Y);
        }

        [TestMethod]
        public void ConcretePoint_TestThatRAndThetaCanBeSet()
        {
            IPoint point = new Chapter06.Models.Point();
            point.SetPolar(8, -6);

            Assert.AreEqual(8, point.R);
            Assert.AreEqual(-6, point.Theta);
        }
    }
}
