using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Element
    {
        public long Id { get; set; }
        public long IdGroup { get; set; }
        public long IdObject { get; set; }

        public virtual Group IdGroupNavigation { get; set; }
    }
}
