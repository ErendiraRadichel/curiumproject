using System.ComponentModel.DataAnnotations;

namespace APIHotProducts.Models
{
    public class Target
    {
        public int ID { get; set; }
        public string Product { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public int LotNum { get; set; }

        public string TargetType { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }
}
