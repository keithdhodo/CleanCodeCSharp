using Chapter06.Interfaces;
using System;

namespace Chapter06.Models
{
    public class Circle : IShape
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }

        private Circle()
        {

        }

        public Circle(Point center, double radius) : this()
        {
            Center = center;
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
