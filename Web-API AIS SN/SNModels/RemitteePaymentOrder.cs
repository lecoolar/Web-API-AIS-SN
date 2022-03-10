using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RemitteePaymentOrder
    {
        public RemitteePaymentOrder()
        {
            Jn1s = new HashSet<Jn1>();
            PayJns = new HashSet<PayJn>();
        }

        public long Id { get; set; }
        public long RemitteeId { get; set; }
        public string Number { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }

        public virtual Remittee Remittee { get; set; }
        public virtual ICollection<Jn1> Jn1s { get; set; }
        public virtual ICollection<PayJn> PayJns { get; set; }
    }
}
