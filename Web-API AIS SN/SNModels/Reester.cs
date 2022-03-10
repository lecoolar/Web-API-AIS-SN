using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Reester
    {
        public Reester()
        {
            ReesterRecords = new HashSet<ReesterRecord>();
        }

        public long Id { get; set; }
        public string PaymentSystem { get; set; }
        public long? PaymentSystemId { get; set; }
        public string Number { get; set; }
        public int? ReeTypeId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Organization { get; set; }
        public long? OrganizationId { get; set; }
        public decimal? Summ { get; set; }
        public int? Records { get; set; }
        public int? StatusId { get; set; }
        public DateTime? PaymentOrderDate { get; set; }
        public DateTime? PaymentOrderPeriod { get; set; }
        public long? PaymentOrderId { get; set; }
        public DateTime? RepPaymentOrderDate { get; set; }
        public string ServiceCode { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public DateTime? IndicationDate { get; set; }
        public long? UserId { get; set; }
        public decimal? CommissionSumm { get; set; }
        public decimal? TransferSumm { get; set; }
        public int CashPaymentOrderType { get; set; }
        public int? CountNewConsumption { get; set; }
        public int? CountNewConsumptionError { get; set; }
        public long? HouseHolderId { get; set; }
        public int? ReasonReturnId { get; set; }
        public string Md5 { get; set; }
        public string FileName { get; set; }
        public int? CountRecordsWithCountersIndications { get; set; }
        public long? GroupOperIdForCountersIndications { get; set; }
        public bool? PayCurrentReceipt { get; set; }

        public virtual Organization1 HouseHolder { get; set; }
        public virtual Organization1 OrganizationNavigation { get; set; }
        public virtual PaymentOrder1 PaymentOrder { get; set; }
        public virtual PaymentSystem PaymentSystemNavigation { get; set; }
        public virtual FasetItem ReasonReturn { get; set; }
        public virtual FasetItem ReeType { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ReesterRecord> ReesterRecords { get; set; }
    }
}
