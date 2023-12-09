namespace Vaux.DTO.Out
{
    public class StatusChangeOutDTO
    {
        public string StatusChangeReason { get; set; }

        public int StatusChangedById { get; set; }

        public string StatusFrom { get; set; }
        public string StatusTo { get; set; }
    }
}
