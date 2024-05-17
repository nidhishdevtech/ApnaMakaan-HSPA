using System.ComponentModel.DataAnnotations;

namespace ApnaMakaanAPI.BLL.DTOs
{
    public class CityRequestDTO
    {
        public int Id { get; set; }

        [Required]
        public string CityName { get; set; } = null!;
        [Required]
        public string CountryName { get; set; } = null!;
    }
}
