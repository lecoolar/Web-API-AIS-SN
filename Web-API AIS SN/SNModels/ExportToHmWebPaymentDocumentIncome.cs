using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebPaymentDocumentIncome
    {
        public long Id { get; set; }
        public long RemotePaymentDocumentId { get; set; }
        public long? ServiceGroupCode { get; set; }
        public decimal? Rate { get; set; }
        public decimal? TotalPayable { get; set; }
        public decimal? AccountingPeriodTotal { get; set; }
        public string CalcExplanation { get; set; }
        public decimal? MoneyRecalculation { get; set; }
        public decimal? MoneyDiscount { get; set; }
        public decimal? PaymentPeriodPiecemealPaymentSum { get; set; }
        public decimal? PastPaymentPeriodPiecemealPaymentSum { get; set; }
        public decimal? PiecemealPaymentPercentRub { get; set; }
        public decimal? PiecemealPaymentPercent { get; set; }
        public decimal? PiecemealPaymentSum { get; set; }
        public string RecalculationReason { get; set; }
        public decimal? RecalculationSum { get; set; }
        public decimal? IndividualConsumptionCurrentValue { get; set; }
        public decimal? HouseOverallNeedsCurrentValue { get; set; }
        public decimal? HouseTotalIndividualConsumption { get; set; }
        public decimal? HouseTotalHouseOverallNeeds { get; set; }
        public decimal? HouseOverallNeedsNorm { get; set; }
        public decimal? IndividualConsumptionNorm { get; set; }
        public decimal? VolumeIndividual { get; set; }
        public decimal? VolumeHouse { get; set; }
        public bool? VolumeIndividualDeterminingMethod { get; set; }
        public bool? VolumeHouseDeterminingMethod { get; set; }
        public decimal? MunicipalServiceIndividualConsumptionPayable { get; set; }
        public decimal? MunicipalServiceCommunalConsumptionPayable { get; set; }
        public decimal? DebtStart { get; set; }
        public decimal? Raised { get; set; }
        public DateTime? Created { get; set; }
        public long? RemoteProviderOrgId { get; set; }
        public decimal? PenaltiesSum { get; set; }
        public decimal? TotalPayableWithDebt { get; set; }
        public decimal? AccountingPeriodIndividual { get; set; }
        public decimal? AccountingPeriodHouse { get; set; }
        public decimal? MultiplyingFactorRatio { get; set; }
        public decimal? MultiplyingFactorExcessFees { get; set; }
        public DateTime? Period { get; set; }
        public string BankBik { get; set; }
        public string BankName { get; set; }
        public string OperatingAccountNumber { get; set; }
        public string CorrespondentAccountNumber { get; set; }
    }
}
