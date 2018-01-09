using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    public class CopyCharsExample
    {
        public static void CopyChars(char[] a1, char[] a2)
        {
            if (a2.Length < a1.Length)
            {
                a2 = new char[a1.Length];
            }

            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
        }
    }
}
