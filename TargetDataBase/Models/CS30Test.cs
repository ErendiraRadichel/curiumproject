using System.ComponentModel.DataAnnotations;

namespace TargetDataBase.Models
{
    public class CS30Test
    {
        public int ID { get; set; }

        [Display(Name = "Target ID")]
        public int CS30ID { get; set; }

        public string Result { get; set; }

        [Display(Name = "H-Number")]
        public string HNum { get; set; }

        public CS30 CS30 { get; set; }
    }
}
