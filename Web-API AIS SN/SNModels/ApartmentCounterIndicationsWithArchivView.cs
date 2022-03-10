using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterIndicationsWithArchivView
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public decimal Val { get; set; }
        public decimal? PrevVal { get; set; }
        public int ValType { get; set; }
        public string ValTypeName { get; set; }
        public DateTime ValDate { get; set; }
        public DateTime? PrevValDate { get; set; }
        public DateTime Created { get; set; }
        public long? GroupOperId { get; set; }
        public string Comment { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public string CounterTypeName { get; set; }
        public string CounterName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public int? SourceValType { get; set; }
        public string SourseValName { get; set; }
        public string UserName { get; set; }
        public decimal? Consumption { get; set; }
        public long? InvoiceNumber { get; set; }
        public long? Pack { get; set; }
        public int? AvgConsumption { get; set; }
        public int? MethodValInsert { get; set; }
        public string MethodValInsertName { get; set; }
        public decimal? ValRevert { get; set; }
        public decimal? PrevValRevert { get; set; }
        public bool IsSaveAfterTime { get; set; }
        public bool? IsArchived { get; set; }
    }
}
