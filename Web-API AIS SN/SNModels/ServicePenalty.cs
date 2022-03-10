using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServicePenalty
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public decimal PenaltyPercent { get; set; }
        public byte PenaltyDay { get; set; }
        public long? DocId { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual OrgDocument Doc { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
