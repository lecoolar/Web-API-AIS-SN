using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesWithArchivView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ServiceApartmentTypeName { get; set; }
        public string CounterCount { get; set; }
        public string CounterName { get; set; }
        public string EquipmentCount { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal? LastRate { get; set; }
        public decimal? CurrentRate { get; set; }
        public int OrgCode { get; set; }
        public string OrgName { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderShortName { get; set; }
        public string FinancialCenterShortName { get; set; }
        public string GeneralContractorShortName { get; set; }
        public string ExecutorGisName { get; set; }
        public DateTime Created { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BalancePeni { get; set; }
        public decimal? SummCashlessPayments { get; set; }
        public DateTime? RecalcStartPeriod { get; set; }
        public int? IsArchived { get; set; }
    }
}
