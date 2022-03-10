using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentSystemAgent
    {
        public long Id { get; set; }
        public long OrganizationId { get; set; }
        public long PaymentSystemId { get; set; }
        public string ExternalNumber { get; set; }
        public int? CashFlowTypeId { get; set; }
        public decimal? RoubleRateCommission { get; set; }
        public decimal? PercentRateCommission { get; set; }
        public decimal? PercentRateCommissionOnTop { get; set; }
        public long? CashlessOrgId { get; set; }

        public virtual FasetItem CashFlowType { get; set; }
        public virtual Organization1 CashlessOrg { get; set; }
        public virtual Organization1 Organization { get; set; }
        public virtual PaymentSystem PaymentSystem { get; set; }
    }
}
