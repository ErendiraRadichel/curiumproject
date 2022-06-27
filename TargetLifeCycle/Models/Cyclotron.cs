using System;

namespace TargetLifeCycle.Models
{
    public class Cyclotron
    {
        public int CyclotronID { get; set; }
        public string CyclotronName { get; set; }
        public DateTime CyclotronDate { get; set; }

        //References
        public int TargetID { get; set; }
        public Target Target { get; set; }

        public int WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
