namespace ApnaMakaanAPI.BLL.DTOs
{
    public class CityPropertyResponseDTO
    {
        //city data to show
        public string CityName { get; set; } = null!;
        public string CountryName { get; set; } = null!;

        //propoerty data to show with specific city

        public List<PropertyResponseDTO> Properties { get; set; }
       
    }
}
