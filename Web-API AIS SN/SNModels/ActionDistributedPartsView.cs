using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionDistributedPartsView
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public int IndexPart { get; set; }
        public bool IsReady { get; set; }
        public int? StationNumber { get; set; }
        public int? IndexFirstAccount { get; set; }
        public DateTime Created { get; set; }
        public string HostName { get; set; }
        public string FileName { get; set; }
        public DateTime? FinishTime { get; set; }
        public int? PageCount { get; set; }
        public int? AccountCount { get; set; }
        public int? AccountInFileCount { get; set; }
        public int? SessionId { get; set; }
        public bool IsActive { get; set; }
        public string Error { get; set; }
        public int? RunNow { get; set; }
        public int? ExistFileData { get; set; }
    }
}
