using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Sort { get; set; }
        public long ActionId { get; set; }

        public virtual Action Action { get; set; }
    }
}
