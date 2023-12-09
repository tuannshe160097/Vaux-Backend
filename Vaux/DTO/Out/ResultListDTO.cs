using Vaux.Models;

namespace Vaux.DTO.Out
{
    public class ResultListDTO<T>
    {
        public ICollection<T> Records { get; set; }
        public int TotalRecords { get; set; }
        public int RecordsSkipped { get; set; }
        public int RecordsTaken { get; set; }
    }
}
