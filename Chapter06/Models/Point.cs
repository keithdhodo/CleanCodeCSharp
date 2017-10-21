using Chapter06.Interfaces;
using System;

namespace Chapter06.Models
{
    public class Point : IPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void SetCartesian(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void SetPolar(double r, double theta)
        {
            X = r;
            Y = theta;
        }
    }
}
