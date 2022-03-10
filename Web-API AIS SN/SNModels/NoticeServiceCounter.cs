using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeServiceCounter
    {
        public long NoticeServiceId { get; set; }
        public long NoticeCounterId { get; set; }

        public virtual NoticeCounter NoticeCounter { get; set; }
        public virtual NoticeService NoticeService { get; set; }
    }
}
