using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCountersIndicationsForLk
    {
        public long ApartmentId { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterServiceTypeName { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public string CounterNumber { get; set; }
        public string ScaleTypeName { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public decimal? Val { get; set; }
        public DateTime? ValDate { get; set; }
        public string ValTypeName { get; set; }
        public int? CounterSize { get; set; }
        public string MethodValInsertName { get; set; }
        public string NewValType { get; set; }
        public string CounterNumberAismeter { get; set; }
        public DateTime? ServiceToDate { get; set; }
    }
}
