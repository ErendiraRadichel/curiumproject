using System.ComponentModel.DataAnnotations;

namespace APIHotProducts.Models
{
    public class Target
    {
        // Primary Key, unique
        public int ID { get; set; }
        public string Status { get; set; } = string.Empty;

        // Warehouse Columns
        public string TargetType { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Creation Date")]
        public DateTime WarehouseDate { get; set; }

        [Display(Name = "Name")]
        public string WarehouseName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string WarehouseCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public int WarehouseLotNum { get; set; }

        // Cyclotron Spares Columns
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime CyclotronDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string CyclotronName { get; set; } = string.Empty;

        // Chemistry: Plating
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime PlatingDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string PlatingName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string PlatingCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public int PlatingLotNum { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = string.Empty;

        [Display(Name = "Target Number")]
        public int TargetNum { get; set; }

        //Cyclotron: Bombarding
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime BombardingDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string BombardingName { get; set; } = string.Empty;

        //Chemistry: Processing
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime ProcessingDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string ProcessingName { get; set; } = string.Empty;
        
    }
}
