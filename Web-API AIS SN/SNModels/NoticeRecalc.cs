using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeRecalc
    {
        public long Id { get; set; }
        public long NoticeId { get; set; }
        public string GroupName { get; set; }
        public string SubTypeName { get; set; }
        public decimal? Summ { get; set; }
    }
}
