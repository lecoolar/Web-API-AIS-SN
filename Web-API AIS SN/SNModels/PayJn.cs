using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PayJn
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public decimal Summ { get; set; }
        public byte CalcOperId { get; set; }
        public long? GroupOperId { get; set; }
        public long? RemitteePaymentOrderId { get; set; }
        public long? BankPaymentOrderRecordInputId { get; set; }
        public long? BankPaymentOrderRecordOutputId { get; set; }
        public long ReesterRecordId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual CalcOperation CalcOper { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual ReesterRecord ReesterRecord { get; set; }
        public virtual RemitteePaymentOrder RemitteePaymentOrder { get; set; }
    }
}
