namespace Vaux.DTO
{
    public class SellerApplicationDTO
    {
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
    }
}
