﻿using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class UserStrictDTO
    {
        [MaxLength(40)]
        public string Name { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }

        [MaxLength(64)]
        [Required(AllowEmptyStrings = false)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? District { get; set; }

        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(100)]
        public string? HouseNumber { get; set; }

        [MaxLength(256)]
        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }

        [MaxLength(13)]
        [RegularExpression(@"^\d+$")]
        [Required(AllowEmptyStrings = false)]
        public string CitizenId { get; set; }

        [MaxLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string Gender { get; set; }

        public DateTime DoB { get; set; }

        [MaxLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string BankAccountNum { get; set; }

        [MaxLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string BankCode { get; set; }

        [MaxLength(200)]
        [Required(AllowEmptyStrings = false)]
        public string BankName { get; set; }
    }
}
