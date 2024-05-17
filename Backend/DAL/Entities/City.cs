using System;
using System.Collections.Generic;

namespace ApnaMakaanAPI.DAL.Entities
{
    public partial class City
    {
        public City()
        {
            Properties = new HashSet<Property>();

        }

        public int Id { get; set; }
        public string CityName { get; set; } = null!;
        public string CountryName { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}
