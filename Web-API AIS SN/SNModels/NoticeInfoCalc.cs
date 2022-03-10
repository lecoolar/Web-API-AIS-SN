using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeInfoCalc
    {
        public long Id { get; set; }
        public long NoticeId { get; set; }
        public int? ProviderCode { get; set; }
        public string GroupName { get; set; }
        public string CounterType { get; set; }
        public string CounterNumber { get; set; }
        public decimal? StartIndication { get; set; }
        public decimal? EndIndication { get; set; }
        public decimal? Resource { get; set; }
        public decimal? NormRate { get; set; }
        public decimal? HouseSquare { get; set; }
        public decimal? GroupResource { get; set; }
        public decimal? HouseResource { get; set; }
    }
}
