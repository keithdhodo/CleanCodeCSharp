using Chapter04;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;

namespace Chapter04Tests
{
    [TestClass]
    public class SieveOfEratosthenesTests
    {
        public SieveOfEratosthenes Sieve { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Sieve = new SieveOfEratosthenes();
        }

        [TestMethod]
        public void SieveOfEratosthenes_GeneratePrimes_NumberOne()
        {
            var actual = Sieve.GeneratePrimes(new BigInteger(1));
            CollectionAssert.AreEqual(new List<BigInteger>(), actual);
        }
    }
}
