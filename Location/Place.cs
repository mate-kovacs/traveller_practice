using System;
using System.Collections.Generic;
using System.Text;

namespace Location
{
    public class Place
    {
        public Coord Coordinate { get; private set; }
        public string Name { get; set; }

        public Place(Coord coord, string name)
        {
            this.Name = name;
            this.Coordinate = coord;
        }

        public double DistanceFrom(Place target)
        {
            return Math.Sqrt(Math.Pow(Coordinate.X - target.Coordinate.X, 2.0) + Math.Pow(Coordinate.Y - target.Coordinate.Y, 2.0));
        }
    }
}
