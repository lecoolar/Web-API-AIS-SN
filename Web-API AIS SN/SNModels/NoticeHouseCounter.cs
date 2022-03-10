using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeHouseCounter
    {
        public long Id { get; set; }
        public long NoticeId { get; set; }
        public long HouseCounterId { get; set; }
        public string CounterNumber { get; set; }
        public string CounterTypeName { get; set; }
        public int? Capacity { get; set; }
        public decimal? HouseConsumption { get; set; }
        public decimal? HouseConsumptionVolume { get; set; }
        public decimal? ApatrmentCountersVolume { get; set; }
        public decimal? ApatrmentNormativesVolume { get; set; }
        public decimal? HouseIndication { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? ServiceId { get; set; }
        public long? AccountServiceId { get; set; }
        public long? NoticeServiceId { get; set; }
        public string UnitName { get; set; }
        public decimal? HouseMopconsumption { get; set; }
        public decimal? Factor { get; set; }
        public DateTime? IndicationDate { get; set; }
        public decimal? IndicationPrev { get; set; }
        public DateTime? IndicationDatePrev { get; set; }
        public decimal? NonresidentialConsumptions { get; set; }
        public bool IsInnerVolume { get; set; }
        public decimal? RevertConsumptions { get; set; }
        public bool IsSubCounter { get; set; }
        public decimal? ValInfo { get; set; }
        public string Note { get; set; }
        public string NotePrev { get; set; }
        public long? ParentHouseCounterId { get; set; }
        public decimal? HierarchyConsumptionInfo { get; set; }
        public decimal? Consumption { get; set; }

        public virtual Notice Notice { get; set; }
    }
}
