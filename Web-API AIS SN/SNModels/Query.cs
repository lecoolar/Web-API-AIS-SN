using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Query
    {
        public long Id { get; set; }
        public string Block { get; set; }
        public short? BlockingSessionId { get; set; }
        public int CpuTime { get; set; }
        public DateTime? Created { get; set; }
        public string Db { get; set; }
        public string DbLogin { get; set; }
        public string DbUser { get; set; }
        public string HostName { get; set; }
        public long LogicalReads { get; set; }
        public string Plan { get; set; }
        public string ProcName { get; set; }
        public string ProgramName { get; set; }
        public string QueryText { get; set; }
        public long Reads { get; set; }
        public string RunTime { get; set; }
        public short SessionId { get; set; }
        public string Status { get; set; }
        public string Uid { get; set; }
        public int UserId { get; set; }
        public int WaitTime { get; set; }
        public string WaitType { get; set; }
        public long Writes { get; set; }
    }
}
