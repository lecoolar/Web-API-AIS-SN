using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseFormControl
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int FormControlId { get; set; }
        public DateTime FromDate { get; set; }
        public long HouseId { get; set; }
        public DateTime? ToDate { get; set; }

        public virtual FasetItem FormControl { get; set; }
        public virtual House House { get; set; }
    }
}
