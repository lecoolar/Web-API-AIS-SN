using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionReportDbfResult
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public string Date { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string CountAccountWithResult { get; set; }
    }
}
