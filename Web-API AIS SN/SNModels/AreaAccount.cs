using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaAccount
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long AccountId { get; set; }
        public int? IndexPart { get; set; }
        public int? Number { get; set; }
        public int? NumberGroup { get; set; }

        public virtual Account Account { get; set; }
        public virtual Area Area { get; set; }
    }
}
