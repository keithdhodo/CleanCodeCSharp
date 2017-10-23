using Chapter06.Interfaces;

namespace Chapter06.Models
{
    public class Rectangle : IShape
    {
        public Point TopLeft { get; private set; }
        public double Height { get; private set; }
        public double Width { get; private set; }

        private Rectangle()
        {

        }

        public Rectangle(Point topleft, double height, double width) : this()
        {
            TopLeft = topleft;
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return Height * Width;
        }
    }
}
