using System.ComponentModel.DataAnnotations;
using Vaux.Models.Enums;

namespace Vaux.DTO
{
    public class StatusChangeDTO
    {
        public ItemStatus Status { get; set; }

        [MaxLength(256)]
        public string StatusChangeReason { get; set; }
    }
}
