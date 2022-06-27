using System;

namespace TargetLifeCycle.Models
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public DateTime WarehouseDate { get; set; }
        public int WarehouseLotNum { get; set; }
        public string WarehouseCode { get; set; }

        //References
        public int TargetID { get; set; }
        public Target Target { get; set; }
    }
}
