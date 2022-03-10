using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcNodesView
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long NodeId { get; set; }
        public string SrvName { get; set; }
        public string DbName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public long? AreaId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int CalcStatusId { get; set; }
        public string StatusName { get; set; }
        public int? NodeStatusId { get; set; }
        public string NodeStatusName { get; set; }
        public long? CurrentCalcId { get; set; }
        public int? ChargeStatusId { get; set; }
    }
}
