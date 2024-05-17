namespace ApnaMakaanAPI.BLL.DTOs
{
    public class UserPropertyResponseDTO
    {
        public string UserName { get; set; } = null!;
        public string FullName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public List<PropertyResponseDTO> Properties { get; set; }
    }
}
