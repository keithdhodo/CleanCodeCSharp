using Chapter05;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05Tests
{
    [TestClass]
    public class QuadraticTests
    {
        [TestMethod]
        public void Quadratic_Test_Double_OneTwoThree()
        {
            var expected = double.NaN;
            var actual = Quadratic.Root(1.0, 2.0, 3.0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Quadratic_Test_Double_ThreeOneHundredOne()
        {
            var expected = Math.Round(-0.0100030018013513, 15);
            var actual = Math.Round(Quadratic.Root(3.0, 100.0, 1.0), 15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Quadratic_Test_Int_OneTwoThree()
        {
            var expected = double.NaN;
            var actual = Quadratic.Root(1, 2, 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Quadratic_Test_Int_ThreeOneHundredOne()
        {
            var expected = Math.Round(-0.0100030018013513, 15);
            var actual = Math.Round(Quadratic.Root(3, 100, 1), 15);

            Assert.AreEqual(expected, actual);
        }
    }
}
