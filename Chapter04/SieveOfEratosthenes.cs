using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    public class SieveOfEratosthenes
    {
        public List<int> GeneratePrimes(int input)
        {
            var returnList = new List<int>();

            if (input > 1)
            {
                bool[] boolArray = new bool[input + 1];

                for (int i = 2; i < input + 1; i++)
                {
                    boolArray[i] = true;
                }

                for (int i = 2; i < input + 1; i++)
                {
                    // easier for readability; granted could just use boolArray[i]
                    if (boolArray[i])
                    {
                        for (int j = i; j * i < input + 1 && j * i < int.MaxValue && j * i > 0; j++)
                        {
                            boolArray[i * j] = false;
                        }
                    }
                }

                for (int i = 0; i < input +1; i++)
                {
                    if (boolArray[i])
                    {
                        returnList.Add(i);
                    }
                }
            }

            return returnList;
        }
    }
}
