using System;
using System.Collections.Generic;

namespace ApnaMakaanAPI.DAL.Entities
{
    public partial class FurnishingType
    {
        public FurnishingType()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        public string FurnishingType1 { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}
