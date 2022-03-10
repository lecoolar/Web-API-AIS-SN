using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperationSequence
    {
        public long ParentId { get; set; }
        public long ChildId { get; set; }
        public int TypeId { get; set; }

        public virtual GroupOperation Child { get; set; }
        public virtual GroupOperation Parent { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
