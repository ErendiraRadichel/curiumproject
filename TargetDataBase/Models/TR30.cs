using System.ComponentModel.DataAnnotations;

namespace TargetDataBase.Models
{
#pragma warning disable CS8632
    public class TR30
    {
        // Primary Key, unique
        public int ID { get; set; }
        public string Status { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Creation Date")]
        public DateTime WarehouseDate { get; set; }

        [Display(Name = "Name")]
        public string WarehouseName { get; set; } = string.Empty;

        [Display(Name = "Face Code")]
        public string WFaceCode { get; set; } = string.Empty;

        [Display(Name = "Body Code")]
        public string WBodyCode { get; set; } = string.Empty;

        [Display(Name = "Face Lot Number")]
        public string WFaceLotNum { get; set; } = string.Empty;

        [Display(Name = "Body Lot Number")]
        public string WBodyLotNum { get; set; } = string.Empty;

        // Cyclotron Spares Columns
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? CyclotronDate { get; set; }

        [Display(Name = "Name")]
        public string? CyclotronName { get; set; } = string.Empty;

        public string? CFaceCode { get; set; } = string.Empty;

        public string? CBodyCode { get; set; } = string.Empty;

        public string? Quantity { get; set; } = string.Empty;

        public ICollection<TR30Test> TR30Tests { get; set; }

        // Chemistry: Plating
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy H:mm tt}")]
        [Display(Name = "Date")]
        public DateTime? PlatingDate { get; set; }

        [Display(Name = "Name")]
        public string? PlatingName { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string? PlatingCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string? PlatingLotNum { get; set; } = string.Empty;

        [Display(Name = "Isotope")]
        public string? ProductName { get; set; } = string.Empty;

        [Display(Name = "Target Number")]
        public string? TargetNum { get; set; } = string.Empty;

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
