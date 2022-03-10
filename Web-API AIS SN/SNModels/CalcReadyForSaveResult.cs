using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcReadyForSaveResult
    {
        public long CalcId { get; set; }
        public int? CntNode { get; set; }
        public int? CntReady { get; set; }
    }
}
