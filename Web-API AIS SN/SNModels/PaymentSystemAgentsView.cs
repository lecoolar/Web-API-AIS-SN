using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentSystemAgentsView
    {
        public long Id { get; set; }
        public long OrganizationId { get; set; }
        public int OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public long PaymentSystemId { get; set; }
        public string PaymentSystemName { get; set; }
        public string ExternalNumber { get; set; }
        public int? CashFlowTypeId { get; set; }
        public string CashFlowTypeName { get; set; }
        public decimal? PercentRateCommission { get; set; }
        public decimal? RoubleRateCommission { get; set; }
        public decimal? PercentRateCommissionOnTop { get; set; }
        public long? CashlessOrgId { get; set; }
        public string CashlessOrgName { get; set; }
    }
}
