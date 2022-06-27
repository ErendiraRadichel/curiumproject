using System;
using System.ComponentModel.DataAnnotations;

namespace TargetLifeCycle.Models
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }

        [Display(Name = "Code")]
        public string WarehouseCode { get; set; }

        [Display(Name = "Lot Number")]
        public int WarehouseLotNum { get; set; }

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
