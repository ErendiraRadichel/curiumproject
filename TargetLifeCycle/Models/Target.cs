namespace TargetLifeCycle.Models
{
    public class Target
    {
        public int TargetID { get; set; }
        public string TargetType { get; set; }
        public string Status { get; set; }

        //References
        public Warehouse Warehouse { get; set; }
        public Cyclotron Cyclotron { get; set; }
    }
}
