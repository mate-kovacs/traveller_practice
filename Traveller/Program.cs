using System;
using System.Collections.Generic;
using TravelManager;
using Location;
using Location.Types;

namespace Traveller
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Console.WriteLine(manager.hello());

            Coord bpCoord = new Coord(5.5, 4.5);
            Place budapest = new City(bpCoord, "Budapest", 2000000);
            Coord pCoord = new Coord(4.5, 5.5);
            Place prague = new City(pCoord, "Prague", 2600000);

            manager.AddPlace(budapest);
            manager.AddPlace(prague);

            List<Place> places = new List<Place>();
            places = manager.Places;
            foreach (Place place in places)
            {
                if (place is City)
                {
                    Console.WriteLine($"{place.Name} is a city with {((City)place).Population} citizens.");
                    Console.WriteLine(((City)place).Visit());
                }
                
            }
            double distance = budapest.DistanceFrom(prague);
            Console.WriteLine($"The distance between {budapest.Name} and {prague.Name} is {distance}");

        }
    }
}
