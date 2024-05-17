using System;
using System.Collections.Generic;

namespace ApnaMakaanAPI.DAL.Entities
{
    public partial class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public int PropertyId { get; set; }

        public virtual Property Property { get; set; } = null!;
    }
}
