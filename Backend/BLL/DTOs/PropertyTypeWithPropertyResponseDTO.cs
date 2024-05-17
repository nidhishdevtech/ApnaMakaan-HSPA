using ApnaMakaanAPI.DAL.Entities;

namespace ApnaMakaanAPI.BLL.DTOs
{
    public class PropertyTypeWithPropertyResponseDTO
    {
        public int Id { get; set; }
        public string PropertyType1 { get; set; } = null!;

        public virtual ICollection<PropertyResponseDTO> Properties { get; set; }
    }
}
