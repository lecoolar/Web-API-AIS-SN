using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterIndication
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public decimal Val { get; set; }
        public int ValType { get; set; }
        public DateTime ValDate { get; set; }
        public DateTime Created { get; set; }
        public long? GroupOperId { get; set; }
        public string Comment { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public long? InvoiceNumber { get; set; }
        public long? Pack { get; set; }
        public int? MethodValInsert { get; set; }
        public int? SourceValType { get; set; }
        public decimal? ValRevert { get; set; }
        public bool IsSaveAfterTime { get; set; }
    }
}
