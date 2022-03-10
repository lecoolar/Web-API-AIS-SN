using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicePaymentInstallmentPart
    {
        public long Id { get; set; }
        public long AccountServicePaymentInstallmentId { get; set; }
        public decimal Summ { get; set; }
        public DateTime Period { get; set; }

        public virtual AccountServicePaymentInstallment AccountServicePaymentInstallment { get; set; }
    }
}
