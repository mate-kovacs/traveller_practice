using System;
using System.Collections.Generic;
using System.Text;

namespace Location
{
    public class Coord
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public Coord(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
