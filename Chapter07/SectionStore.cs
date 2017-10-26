using System;
using System.Collections.Generic;
using System.IO;

namespace Chapter07
{
    public class SectionStore
    {
        public List<RecordedGrip> RetrieveSection(string SectionName)
        {
            try
            {
                var stream = new FileStream(SectionName, FileMode.Open);
            }
            catch(Exception ex)
            {
                throw new IOException("retrieval error", ex);
            }

            return new List<RecordedGrip>();
        }
    }
}
