﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.ValidationAttributes;

namespace Vaux.DTO.Out
{
    public class SellerApplicationOutDTO
    {
        public int Id { get; set; }
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
        public UserOutMinimalDTO User { get; set; }
        public SellerApplicationStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime? Deleted { get; set; }
        public List<StatusChangeOutDTO> StatusChange { get; set; }
        public string BankAccountNum { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
    }
}
