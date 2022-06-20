using System.ComponentModel.DataAnnotations;

namespace APIHotProducts.Models
{
    public class Target
    {
        // Primary Key, unique
        public int ID { get; set; }

        // Product Name, one for target
        public string Product { get; set; } = string.Empty;

        // Warehouse Columns
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Name")]
        public string WName { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string WStatus { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string WCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string WLotNum { get; set; } = string.Empty;

        // Cyclotron Spares Columns
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime CDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string CName { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string CStatus { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string CCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string CLotNum { get; set; } = string.Empty;

        //Chemistry Lab 1
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime C1Date { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string C1Name { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string C1Status { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string C1Code { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string C1LotNum { get; set; } = string.Empty;

        //Cyclotron Bombarding
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime BDate { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string BName { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string BStatus { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string BCode { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string BLotNum { get; set; } = string.Empty;

        //Chemistry Lab 2: After bombarding
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Date")]
        public DateTime C2Date { get; set; } = DateTime.Today;

        [Display(Name = "Name")]
        public string C2Name { get; set; } = string.Empty;

        [Display(Name = "Status")]
        public string C2Status { get; set; } = string.Empty;

        [Display(Name = "Code")]
        public string C2Code { get; set; } = string.Empty;

        [Display(Name = "Lot Number")]
        public string C2LotNum { get; set; } = string.Empty;
        
    }
}
