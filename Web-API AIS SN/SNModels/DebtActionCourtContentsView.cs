using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionCourtContentsView
    {
        public long Id { get; set; }
        public long DebtActionCourtStageId { get; set; }
        public string DebtActionCourtStageName { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }
}
