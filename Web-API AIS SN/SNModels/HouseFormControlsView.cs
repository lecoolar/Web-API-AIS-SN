using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseFormControlsView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public int FormControlId { get; set; }
        public string FormControlName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
