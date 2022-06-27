using System.ComponentModel.DataAnnotations;

namespace TargetLifeCycle.Models
{
    public class Target
    {
        public int TargetID { get; set; }

        [Display(Name = "Target Type")]
        public string TargetType { get; set; }
        public string Status { get; set; }

        //References
        public Warehouse Warehouse { get; set; }
        public Cyclotron Cyclotron { get; set; }
    }
}
