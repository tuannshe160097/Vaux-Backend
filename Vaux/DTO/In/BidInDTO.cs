using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO.In
{
    public class BidInDto
    {
        [Range(10000, int.MaxValue)]
        public long Amount { get; set; }
    }
}
