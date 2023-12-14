using Vaux.Models;

namespace Vaux.DTO.Out
{
    public class UserOutDTO
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Street { get; set; }
        public string? HouseNumber { get; set; }
        public string? CitizenId { get; set; }
        public string? Gender { get; set; }
        public DateTime? DoB { get; set; }
        public bool IsVerified { get; set; }
        public Role Role { get; set; }
        public int? PortraitId { get; set; }
        public int? CitizenIdImageId { get; set; }
        public string? BankAccountNum { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public ICollection<NotificationOutDTO>? Notifications { get; set; }
    }
}
