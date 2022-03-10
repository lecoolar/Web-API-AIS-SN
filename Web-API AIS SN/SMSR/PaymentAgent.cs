using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaymentAgent
    {
        public PaymentAgent()
        {
            PaymentBases = new HashSet<PaymentBasis>();
            Pays = new HashSet<Pay>();
            TypePays = new HashSet<TypePay>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Persent { get; set; }
        public bool? Act { get; set; }
        public int? BankCode { get; set; }
        public bool? ApplePay { get; set; }
        public bool? GooglePay { get; set; }
        public bool? SamsungPay { get; set; }
        public bool? Regular { get; set; }
        public bool? Sbp { get; set; }

        public virtual BankFaset BankCodeNavigation { get; set; }
        public virtual ICollection<PaymentBasis> PaymentBases { get; set; }
        public virtual ICollection<Pay> Pays { get; set; }
        public virtual ICollection<TypePay> TypePays { get; set; }
    }
}
