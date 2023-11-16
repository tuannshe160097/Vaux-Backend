﻿using Vaux.Models;

namespace Vaux.DTO
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
        public ICollection<Notification>? Notifications { get; set; }
    }
}