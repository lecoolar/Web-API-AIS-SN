using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnWithArchivView
    {
        public long Id { get; set; }
        public int ProviderCode { get; set; }
        public string ProviderName { get; set; }
        public string ServiceTypeName { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCodeName { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
        public long AccountId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderName { get; set; }
        public string FinancialCenterName { get; set; }
        public byte CalcOperId { get; set; }
        public string CalcOperName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public decimal Summ { get; set; }
        public decimal? OriginalSumm { get; set; }
        public long? GroupOperId { get; set; }
        public int? OldId { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public long? RemitteePaymentOrderId { get; set; }
        public long? BankPaymentOrderRecordInputId { get; set; }
        public int? BankPaymentOrderRecordOutputId { get; set; }
        public bool? IsUnloadedProvider { get; set; }
        public bool? IsArchived { get; set; }
    }
}
