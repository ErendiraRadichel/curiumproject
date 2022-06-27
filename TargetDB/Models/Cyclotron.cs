using System;
using System.ComponentModel.DataAnnotations;

namespace TargetDB.Models
{
    public class Cyclotron
    {
        public int CyclotronID { get; set; }

        [Display(Name = "Name")]
        public string CyclotronName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        public DateTime CyclotronDate { get; set; }

        //References
        public int TargetID { get; set; }

        public Target Target { get; set; }

        public int WarehouseID { get; set; }

        [Display(Name = "Code")]
        public string WCode { get; set; }

        [Display(Name = "Lot Number")]
        public int WLotNum { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
