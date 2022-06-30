using System.ComponentModel.DataAnnotations;

namespace APIHotProducts.Models
{
#pragma warning disable CS8632
    public class Target
    {
        // Primary Key, unique
        public int ID { get; set; }
        public string Status { get; set; } = string.Empty;

        // Warehouse Columns
        [Display(Name = "Target Type")]
        public string TargetType { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Creation Date")]
        public DateTime WarehouseDate { get; set; }

        [Display(Name = "Name")]
        public string WarehouseName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string WarehouseCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public int WarehouseLotNum { get; set; }

        // Cyclotron Spares Columns
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? CyclotronDate { get; set; }

        [Display(Name = "Name")]
        public string? CyclotronName { get; set; } = string.Empty;

        public int? Quantity { get; set; }

        // Chemistry: Plating
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? PlatingDate { get; set; }

        [Display(Name = "Name")]
        public string? PlatingName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string? PlatingCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public int? PlatingLotNum { get; set; }

        [Display(Name = "Product Name")]
        public string? ProductName { get; set; } = string.Empty;

        [Display(Name = "Target Number")]
        public int? TargetNum { get; set; }

        //Cyclotron: Bombarding
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? BombardingDate { get; set; }

        [Display(Name = "Name")]
        public string? BombardingName { get; set; } = string.Empty;

        //Chemistry: Processing
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? ProcessingDate { get; set; }

        [Display(Name = "Name")]
        public string? ProcessingName { get; set; } = string.Empty;

        [Display(Name = "Processing Lot Number")]
        public string? ProcessingLotNum { get; set; } = string.Empty;
    }
#pragma warning restore CS8632
}
