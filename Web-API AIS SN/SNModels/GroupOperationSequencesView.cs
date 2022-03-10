using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperationSequencesView
    {
        public long ParentId { get; set; }
        public long ChildId { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
