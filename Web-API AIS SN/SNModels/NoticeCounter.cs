using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeCounter
    {
        public NoticeCounter()
        {
            NoticeServiceCounters = new HashSet<NoticeServiceCounter>();
        }

        public long Id { get; set; }
        public long NoticeId { get; set; }
        public long CounterId { get; set; }
        public string CounterNumber { get; set; }
        public string CounterTypeName { get; set; }
        public decimal? StartIndication { get; set; }
        public DateTime? StartIndicationDate { get; set; }
        public decimal? EndIndication { get; set; }
        public DateTime? EndIndicationDate { get; set; }
        public decimal? Consumption { get; set; }
        public string CounterMaddleType { get; set; }
        public string UnitName { get; set; }
        public decimal Share { get; set; }
        public int? EndIndicationTypeId { get; set; }
        public string EndIndicationComment { get; set; }
        public bool? IsCloseCounter { get; set; }
        public DateTime? CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public int? StartIndicationTypeId { get; set; }
        public DateTime? EndIndicationDateWithoutCalc { get; set; }
        public decimal? EndIndicationWithoutCalc { get; set; }
        public DateTime? StartIndicationDateWithoutCalc { get; set; }
        public decimal? StartIndicationWithoutCalc { get; set; }
        public decimal? ConsumptionWithoutCalc { get; set; }

        public virtual Notice Notice { get; set; }
        public virtual ICollection<NoticeServiceCounter> NoticeServiceCounters { get; set; }
    }
}
