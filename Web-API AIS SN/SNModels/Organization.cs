using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Organization
    {
        public DateTime Period { get; set; }
        public long OrgId { get; set; }
        public string ShortName { get; set; }
    }
}
