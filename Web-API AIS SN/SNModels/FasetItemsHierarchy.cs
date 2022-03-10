using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FasetItemsHierarchy
    {
        public long Id { get; set; }
        public int ChildFasetItemId { get; set; }
        public byte Level { get; set; }
        public int ParentFasetItemId { get; set; }

        public virtual FasetItem ChildFasetItem { get; set; }
        public virtual FasetItem ParentFasetItem { get; set; }
    }
}
