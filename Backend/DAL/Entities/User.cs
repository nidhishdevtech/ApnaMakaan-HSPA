using System;
using System.Collections.Generic;

namespace ApnaMakaanAPI.DAL.Entities
{
    public partial class user
    {
        public user()
        {
            Properties = new HashSet<Property>();
        }

        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool IsAdmin { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
