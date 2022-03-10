using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebArchivedAccount
    {
        public long Id { get; set; }
        public DateTime? DateStart { get; set; }
        public string QueueType { get; set; }
    }
}
