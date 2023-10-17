namespace Vaux.DTO
{
    public class ProfileUpdateDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? CitizenId { get; set; }
        public string? Gender { get; set; }
        public DateTime? DoB { get; set; }
    }
}
