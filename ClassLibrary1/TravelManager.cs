using System;
using System.Collections.Generic;
using Location;

namespace TravelManager
{
    public class Manager
    {
        public List<Place> Places { get; }

        public Manager()
        {
            Places = new List<Place>();
        }

        public void AddPlace(Place place)
        {
            Places.Add(place);
        }

        public string hello()
        {
            return "This is just a test method that says hello.";
        }
    }
}
