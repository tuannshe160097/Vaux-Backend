using Vaux.Models.Enums;

namespace Vaux.DTO
{
    public class StatusChangeDTO
    {
        public ItemStatus Status { get; set; }
        public string? StatusChangeReason { get; set; }
    }
}
