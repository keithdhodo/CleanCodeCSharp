using System.Collections.Generic;

namespace Chapter02
{
    public class WhyWouldYouDoThis
    {
        public List<int[]> GetThem(List<int[]> theList)
        {
            var list1 = new List<int[]>();

            foreach(var x in theList)
            {
                if (x[0] == 4)
                {
                    list1.Add(x);
                }
            }

            return list1;
        }
    }
}
