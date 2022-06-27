using System;
using System.ComponentModel.DataAnnotations;

namespace TargetDB.Models
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }

        [Display(Name = "Code")]
        public string WCode { get; set; }

        [Display(Name = "Lot Number")]
        public int WLotNum { get; set; }
       
        [Display(Name = "Name")]
        public string WarehouseName { get; set; }

        [Display(Name = "Date")]
        public DateTime WarehouseDate { get; set; }

        //References
        public int TargetID { get; set; }

        public Target Target { get; set; }

        public Cyclotron Cyclotron { get; set; }
    }
}
