using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApnaMakaanAPI.BLL.DTOs
{
    public class PropertyResponseDTO
    {
        public int Id { get; set; }
        public int SellRent { get; set; }
        public int User { get; set; }
        public string Name { get; set; }
      //  public int PropertyTypeId { get; set; }
        [JsonPropertyName("PropertyType")]
        public string PropertyTypePropertyType1 { get; set; }
        //  public int FurnishingTypeId { get; set; }
        [JsonPropertyName("FurnishingType")]
        public string FurnishingTypeFurnishingType1 { get; set; }

        public int? PropertyTypeId { get; set; }
        public int? FurnishingTypeId { get; set; }

        public int Price { get; set; }
        public int Bhk { get; set; }
        public int BuiltArea { get; set; }


        //  public int CityId { get; set; }
        [JsonPropertyName("CityName")]
        public string CityCityName { get; set; }

        public bool ReadyToMove { get; set; }
        public int CarpetArea { get; set; }
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public int FloorNo { get; set; }
        public int TotalFloors { get; set; }
        public string MainEnterance { get; set; } = null!;
        public int Security { get; set; }
        public int MaintenanceAmount { get; set; }
        public int AgeProperty { get; set; }
        public string Description { get; set; } = null!;
        public DateTime PostedOn { get; set; }
       public string? ImageUrl { get; set; }


    }
}
