using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06.Interfaces
{
    public interface IPoint
    {
        double R { get; }
        double Theta { get; }
        double X { get; }
        double Y { get; }

        void SetCartesian(double x, double y);
        void SetPolar(double r, double theta);
    }
}
