using System.ComponentModel.DataAnnotations;

namespace TargetDataBase.Models
{
    public class IBATest
    {
        public int ID { get; set; }

        [Display(Name = "Target ID")]
        public int IBAID { get; set; }

        [Display(Name = "Test Type")]
        public string TestType { get; set; }

        public string Result { get; set; }

        [Display(Name = "H-Number")]
        public string HNum { get; set; }

        public IBA IBA { get; set; }
    }
}
