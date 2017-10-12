using Chapter02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter02Tests
{
    [TestClass]
    public class GuessStatisticsTests
    {
        [TestMethod]
        public void GuessStatistics_PrintGuessStatistics_Zero()
        {
            var output = new GuessStatistics().PrintGuessStatistics('c', 0);
            Assert.AreEqual(output, "There are no cs");
        }

        [TestMethod]
        public void GuessStatistics_PrintGuessStatistics_One()
        {
            var output = new GuessStatistics().PrintGuessStatistics('c', 1);
            Assert.AreEqual(output, "There is 1 c");
        }

        [TestMethod]
        public void GuessStatistics_PrintGuessStatistics_IntMax()
        {
            var output = new GuessStatistics().PrintGuessStatistics('c', int.MaxValue);
            Assert.AreEqual(output, $"There are {int.MaxValue} cs");
        }

        [TestMethod]
        public void GuessStatistics_PrintGuessStatistics_NegativeOne()
        {
            var output = new GuessStatistics().PrintGuessStatistics('c', -1);
            Assert.AreEqual(output, "There are -1 cs");
        }

        [TestMethod]
        public void GuessStatistics_PrintGuessStatistics_IntMin()
        {
            var output = new GuessStatistics().PrintGuessStatistics('c', int.MinValue);
            Assert.AreEqual(output, $"There are {int.MinValue} cs");
        }
    }
}
