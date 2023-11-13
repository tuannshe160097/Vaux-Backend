using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO
{
    public class BidInDto
    {
        [Range(10000, int.MaxValue)]
        public long Amount { get; set; }
    }
}
