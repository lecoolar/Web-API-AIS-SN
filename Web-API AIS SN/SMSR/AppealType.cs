using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AppealType
    {
        public long Id { get; set; }
        public string TypeName { get; set; }
        public bool? NeedSendToCrm { get; set; }
    }
}
