using Chapter06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter06Tests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void ConcretePoint_TestThatXAndYCannotBeChanged()
        {
            var point = new Chapter06.Models.Point(1, 2);

            Assert.AreEqual(1, point.X);
            Assert.AreEqual(2, point.Y);
        }
    }
}
