using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TmpJn03012022
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ServiceId { get; set; }
        public long? HouseHolderId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public string Guid { get; set; }
        public bool OpenedByError { get; set; }
        public long? OpenDocId { get; set; }
        public long? CloseDocId { get; set; }
        public DateTime? RecalcStartPeriod { get; set; }
    }
}
