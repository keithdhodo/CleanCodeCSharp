using Chapter06.Interfaces;
using System;

namespace Chapter06.Models
{
    public class Square : IShape
    {
        public Point TopLeft { get; private set; }
        public double Side { get; private set; }

        private Square()
        {

        }

        public Square(Point topleft, double side) : this()
        {
            TopLeft = topleft;
            Side = side;
        }

        public double Area()
        {
            return Math.Pow(Side, 2);
        }
    }
}
