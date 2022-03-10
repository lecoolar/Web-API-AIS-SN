using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Indication
    {
        public string Code { get; set; }
        public DateTime ValDate { get; set; }
        public decimal Val { get; set; }
        public long Loadid { get; set; }
        public DateTime Created { get; set; }

        public virtual Load Load { get; set; }
    }
}
