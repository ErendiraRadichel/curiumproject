using System.ComponentModel.DataAnnotations;

namespace TargetDataBase.Models
{
    public class TR30Test
    {
        public int ID { get; set; }

        [Display(Name = "Target ID")]
        public int TR30ID { get; set; }

        [Display(Name = "Test Type")]
        public string TestType { get; set; }

        public string Result { get; set; }

        [Display(Name = "H-Number")]
        public string HNum { get; set; }

        public TR30 TR30 { get; set; }
    }
}
