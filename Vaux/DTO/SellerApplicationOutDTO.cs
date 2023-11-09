using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models;
using Vaux.ValidationAttributes;

namespace Vaux.DTO
{
    public class SellerApplicationOutDTO
    {
        public int? UserId { get; set; }
        public string CitizenId { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public int? PortraitId { get; set; }
        public int? CitizenIdImageId { get; set; }
        public UserMinimalDTO User { get; set; }
    }
}
