using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServicePenaltiesView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal PenaltyPercent { get; set; }
        public byte PenaltyDay { get; set; }
        public long? DocId { get; set; }
        public string DocName { get; set; }
    }
}
