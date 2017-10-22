using Chapter06.Interfaces;
using System;

namespace Chapter06.Models
{
    public class Point : IPoint
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double R { get; private set; }
        public double Theta { get; private set; }

        public Point()
        {
        }

        public void SetCartesian(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void SetPolar(double r, double theta)
        {
            R = r;
            Theta = theta;
        }
    }
}
