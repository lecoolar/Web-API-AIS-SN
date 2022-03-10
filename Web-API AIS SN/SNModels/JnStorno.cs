using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnStorno
    {
        public long Id { get; set; }
        public long GroupOperId { get; set; }
        public long InitialJnId { get; set; }
        public long StornoJnId { get; set; }

        public virtual GroupOperation GroupOper { get; set; }
        public virtual Jn1 InitialJn { get; set; }
        public virtual Jn1 StornoJn { get; set; }
    }
}
