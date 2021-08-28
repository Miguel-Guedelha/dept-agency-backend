using System.Collections.Generic;

namespace API.models
{
    public class Location
    {

        public Location(dynamic location)
        {
            Id = location.id;
            City = location.city;
            Name = location.name;
            Parameters = new List<Parameters>();
            foreach (var item in location.parameters)
            {
                Parameters.Add(new Parameters(item));
            }
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public List<Parameters> Parameters { get; set; }
    }
}