using System;
using System.Collections.Generic;

namespace ApnaMakaanAPI.DAL.Entities
{
    public partial class PropertyType
    {
        public PropertyType()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        public string PropertyType1 { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}
