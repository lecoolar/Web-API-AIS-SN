using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseTreatyCommitmentsView
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long HouseId { get; set; }
        public decimal CostsExecutor { get; set; }
        public long? ServiceId { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderName { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Charge { get; set; }
        public decimal? ChargeAccounts { get; set; }
        public decimal? RecalcAccounts { get; set; }
        public decimal? Delta { get; set; }
        public decimal? PaymentAccounts { get; set; }
        public int? ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal? ServiceNormRate { get; set; }
        public decimal? HouseTotalArea { get; set; }
        public long HouseAdrId { get; set; }
        public DateTime? PeriodMonth { get; set; }
        public decimal? ChargeAccountsNotLiving { get; set; }
        public decimal? PaymentAccountsNotLiving { get; set; }
        public decimal? RecalcAccountsNotLiving { get; set; }
        public decimal? ChargeNotLiving { get; set; }
        public decimal? PaymentPersent { get; set; }
        public decimal? PamentPersentNotLiving { get; set; }
    }
}
