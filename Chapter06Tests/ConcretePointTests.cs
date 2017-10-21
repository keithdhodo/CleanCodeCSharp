using Chapter06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter06Tests
{
    [TestClass]
    public class ConcretePointTests
    {
        [TestMethod]
        public void ConcretePoint_TestThatXAndYCanBeChanged()
        {
            var concretePoint = new ConcretePoint() {x = 1, y = 2 };

            concretePoint.x = 5;
            concretePoint.y = int.MaxValue;

            Assert.AreEqual(5, concretePoint.x);
            Assert.AreEqual(int.MaxValue, concretePoint.y);
        }
    }
}
