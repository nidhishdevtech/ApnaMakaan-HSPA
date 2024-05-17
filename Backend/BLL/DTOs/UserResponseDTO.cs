namespace ApnaMakaanAPI.BLL.DTOs
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool IsAdmin { get; set; }



     
    }
}
