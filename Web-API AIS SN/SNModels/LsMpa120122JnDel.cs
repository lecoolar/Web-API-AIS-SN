using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LsMpa120122JnDel
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
        public long? OldId { get; set; }
    }
}
