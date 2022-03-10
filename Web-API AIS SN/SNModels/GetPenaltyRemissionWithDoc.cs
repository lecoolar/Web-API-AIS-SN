using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GetPenaltyRemissionWithDoc
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime Created { get; set; }
        public string OwnerName { get; set; }
        public string DocInfo { get; set; }
    }
}
