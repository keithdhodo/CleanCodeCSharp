using Chapter07;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Chapter07Tests
{
    [TestClass]
    public class SectionStoreTests
    {
        [ExpectedException(typeof(IOException))]
        [TestMethod]
        public void RecordedGrip_RetrieveSectionShouldThrowInvalidFileName()
        {
            new SectionStore().RetrieveSection("foo");
        }
    }
}
