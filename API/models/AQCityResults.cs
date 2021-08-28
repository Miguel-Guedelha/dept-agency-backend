using System.Collections.Generic;
using System;

namespace API.models
{
    public class AQCityResults
    {

        public AQCityResults(dynamic locations)
        {

            Locations = new List<Location>();
            foreach (var item in locations)
            {
                Locations.Add(new Location(item));
            }

        }

        public List<Location> Locations { get; set; }
    }
}