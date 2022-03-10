using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReestersViewNoCheckSumm
    {
        public long Id { get; set; }
        public string PaymentSystem { get; set; }
        public long? PaymentSystemId { get; set; }
        public string PaymentSystemName { get; set; }
        public string Number { get; set; }
        public int? ReeTypeId { get; set; }
        public string ReeTypeName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Organization { get; set; }
        public long? OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public decimal? Summ { get; set; }
        public int? Records { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? PaymentOrderDate { get; set; }
        public DateTime? PaymentOrderPeriod { get; set; }
        public long? PaymentOrderId { get; set; }
        public string PaymentOrderNumber { get; set; }
        public string PaymentOrderAgentName { get; set; }
        public DateTime? RepPaymentOrderDate { get; set; }
        public string ServiceCode { get; set; }
        public decimal? SummProcessed { get; set; }
        public decimal? SummNotProcessed { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? IndicationDate { get; set; }
        public long? ClientId { get; set; }
        public string ClientName { get; set; }
        public decimal? CommissionSumm { get; set; }
        public decimal? TransferSumm { get; set; }
        public string IsComparingBankRecord { get; set; }
        public int CashPaymentOrderType { get; set; }
        public int? CountNewConsumption { get; set; }
        public int? CountNewConsumptionError { get; set; }
        public long? HouseHolderId { get; set; }
        public string HouseHolderName { get; set; }
        public int? ReasonReturnId { get; set; }
        public string ReasonReturnName { get; set; }
        public string Md5 { get; set; }
        public string FileName { get; set; }
        public int? CountRecordsWithCountersIndications { get; set; }
        public bool? PayCurrentReceipt { get; set; }
    }
}
