using System.ComponentModel.DataAnnotations;

namespace Vaux.DTO.In
{
    public class BidInDto
    {
        [Range(10, long.MaxValue/1000)]
        public long Amount { get; set; }
    }
}
