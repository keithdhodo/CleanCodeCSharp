using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    public class Quadratic
    {
        public static double Root(double a, double b, double c)
        {
            var determinant = Determinant(a, b, c);
            return (-b + Math.Sqrt(determinant)) / (2 * a);
        }

        public static double Root(int a, int b, int c)
        {
            var determinant = Determinant(a, b, c);
            return (-b + Math.Sqrt(determinant)) / (2 * a);
        }

        private static double Determinant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
