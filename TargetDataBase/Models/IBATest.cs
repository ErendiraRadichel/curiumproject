namespace TargetDataBase.Models
{
    public class IBATest
    {
        public int ID { get; set; }

        public int IBAID { get; set; }

        public string TestType { get; set; }

        public string Result { get; set; }

        public string HNum { get; set; }

        public IBA IBA { get; set; }
    }
}
