using System.ComponentModel.DataAnnotations;

namespace TargetDB.Models
{
    public class CS30CurvedTarget
    {
        [Key]
        public int CurvedTestID { get; set; }
        public int CS30CurvedID { get; set; }
        public string JigTest { get; set; }
        public string HNumber { get; set; }

        public CS30Curved CS30Curved { get; set; }
    }
}
