namespace ApnaMakaanAPI.BLL.DTOs
{
    public class FurnishingTypeWithPropertyResponseDTO
    {
        public int Id { get; set; }
        public string FurnishingType1 { get; set; } = null!;

        public List<PropertyResponseDTO> Properties { get; set; }
    }
}
