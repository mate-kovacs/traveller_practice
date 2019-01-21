using System;
using System.Collections.Generic;
using System.Text;

namespace Location.Types
{
    public class City : Place, IVisitable
    {
        public int Population { get; set; }

        public City(Coord coord, string name, int pop) : base(coord, name)
        {
            Population = pop;
        }

        public string Visit()
        {
            return $"Welcome to {this.Name}!";
        }
    }
}
