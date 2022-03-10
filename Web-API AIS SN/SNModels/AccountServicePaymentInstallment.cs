using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicePaymentInstallment
    {
        public AccountServicePaymentInstallment()
        {
            AccountServicePaymentInstallmentParts = new HashSet<AccountServicePaymentInstallmentPart>();
        }

        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? DocId { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
        public decimal? Percent { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? DatePayment { get; set; }
        public string Comment { get; set; }
        public DateTime? DateOfInstallmentAgreement { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual ICollection<AccountServicePaymentInstallmentPart> AccountServicePaymentInstallmentParts { get; set; }
    }
}
