using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalServiceSetting
    {
        public long Id { get; set; }
        public short FasetId { get; set; }

        public virtual Faset Faset { get; set; }
    }
}
