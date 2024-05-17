using System.ComponentModel.DataAnnotations;

public class PropertyRequestDTO
{
        // public int Id { get; set; }
        public int? SellRent { get; set; }
        public int? User { get; set; }
        public string Name { get; set; } = null!;
        public int? PropertyTypeId { get; set; }
        public int? FurnishingTypeId { get; set; }
        public int? Price { get; set; }
        public int? Bhk { get; set; }
        public int? BuiltArea { get; set; }
        public int? CityId { get; set; }
        public bool? ReadyToMove { get; set; }
        public int? CarpetArea { get; set; }
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public int? FloorNo { get; set; }
        public int? TotalFloors { get; set; }
        public string MainEnterance { get; set; } = null!;
        public int? Security { get; set; }
        public int? MaintenanceAmount { get; set; }
        public int? AgeProperty { get; set; }
    


    [StringLength(500)]
        public string Description { get; set; } = null!;

        public DateTime PostedOn { get; set; }

    public string? ImageUrl { get; set; }




}