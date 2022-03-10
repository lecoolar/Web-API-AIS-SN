using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T82927Owner
    {
        public long Id { get; set; }
        public long? PersonId { get; set; }
        public long? OrgId { get; set; }
        public int TypeOwner { get; set; }
    }
}
