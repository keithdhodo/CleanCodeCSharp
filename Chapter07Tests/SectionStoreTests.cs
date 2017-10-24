using Chapter07;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter07Tests
{
    [TestClass]
    public class SectionStoreTests
    {
        [TestMethod]
        public void RecordedGrip_RetrieveSectionShouldThrowInvalidFileName()
        {
            new SectionStore().RetrieveSection();
        }
    }
}
