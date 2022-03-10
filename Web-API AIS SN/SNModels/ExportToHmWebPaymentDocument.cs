using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebPaymentDocument
    {
        public long RemotePaymentDocumentId { get; set; }
        public string PaymentDocumentNumber { get; set; }
        public long? RemoteAccountId { get; set; }
        public string AccountNumber { get; set; }
        public long? RemoteAccountOwnerOrganizationId { get; set; }
        public long? RemoteHouseAddrId { get; set; }
        public string ApartmentNumber { get; set; }
        public string RicInn { get; set; }
        public string RicKpp { get; set; }
        public string RicName { get; set; }
        public string BankBik { get; set; }
        public string BankName { get; set; }
        public string OperatingAccountNumber { get; set; }
        public string CorrespondentAccountNumber { get; set; }
        public int? LivingPersonsNumber { get; set; }
        public decimal? ResidentialSquare { get; set; }
        public decimal? HeatedArea { get; set; }
        public decimal? TotalSquare { get; set; }
        public DateTime? Period { get; set; }
        public decimal? DebtPreviousPeriods { get; set; }
        public decimal? AdvanceBillingPeriod { get; set; }
        public decimal? TotalPiecemealSum { get; set; }
        public DateTime? Created { get; set; }
        public decimal? TotalPayable { get; set; }
        public decimal? TotalPayableNoDebt { get; set; }
        public decimal? TotalPayableByIncome { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public byte? IsDebt { get; set; }
        public DateTime? PeriodOriginal { get; set; }
    }
}
