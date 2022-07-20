using System.ComponentModel.DataAnnotations;

namespace TargetDB.Models
{
    public class CS30Curved
    {
        // Primary Key, unique
        public int ID { get; set; }
        public string Status { get; set; } = string.Empty;

        // Warehouse Columns
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Creation Date")]
        public DateTime WarehouseDate { get; set; }

        [Display(Name = "Name")]
        public string WarehouseName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string WarehouseCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string WarehouseLotNum { get; set; } = string.Empty;

        public ICollection<CS30CurvedTarget> CS30CurvedTargets { get; set; }
    }
}
