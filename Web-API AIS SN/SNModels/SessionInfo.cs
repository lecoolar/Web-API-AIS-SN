using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SessionInfo
    {
        public long Id { get; set; }
        public long SessionId { get; set; }
        public DateTime Updated { get; set; }
        public int? ParentTypeId { get; set; }
        public long? ParentId { get; set; }
        public string ActionName { get; set; }
        public string ProcedureName { get; set; }
        public string Comment { get; set; }
        public int? Step { get; set; }
        public int? OfStep { get; set; }
        public int? SubStep { get; set; }
        public int? OfSubStep { get; set; }
    }
}
