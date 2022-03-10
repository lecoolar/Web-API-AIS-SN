using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServiceCountersByDaysView
    {
        public long Id { get; set; }
        public long CsbdId { get; set; }
        public long CalcId { get; set; }
        public decimal? ChargeSumm { get; set; }
        public decimal? Rate { get; set; }
        public decimal? RateForDay { get; set; }
        public long? CounterId { get; set; }
        public string CounterName { get; set; }
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
        public DateTime Period { get; set; }
        public long AccountServiceId { get; set; }
        public decimal? PeriodChargeSumm { get; set; }
        public decimal? PeriodCounterConsumption { get; set; }
        public string UiFormula { get; set; }
    }
}
