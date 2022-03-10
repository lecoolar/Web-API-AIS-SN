using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TmpSnCalcServiceCountersByDay
    {
        public long Id { get; set; }
        public long CsbdId { get; set; }
        public long CalcId { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateForDay { get; set; }
        public long? CounterId { get; set; }
        public long? AccountServiceRelationsId { get; set; }
        public decimal? CounterPaymentShare { get; set; }
        public string CounterMaddleType { get; set; }
        public long? CounterTurnoverSize { get; set; }
        public decimal? CounterConsumption { get; set; }
        public decimal? CounterInternalFactor { get; set; }
        public decimal? CounterExternalFactor { get; set; }
        public decimal? SuspensionFactor { get; set; }
        public decimal? IsSuspensionChargeSumm { get; set; }
        public decimal? LastIndication { get; set; }
        public decimal? FirstIndication { get; set; }
        public string UiFormula { get; set; }
        public decimal? SuspensionFactorCounter { get; set; }
        public decimal? NormCounterConsumption { get; set; }
        public int? IsClosed { get; set; }
        public decimal? FactorConsumption { get; set; }
        public DateTime? LastIndicationDate { get; set; }
        public DateTime? FirstIndicationDate { get; set; }
        public long? UserId { get; set; }
        public int? LastIndicationType { get; set; }
        public bool? IsFictiveCheckInterval { get; set; }
        public decimal? RateWithoutNds { get; set; }
        public decimal? PaymentInd { get; set; }
    }
}
