using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeGroupsView
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public long ChildId { get; set; }
        public string ParentShortName { get; set; }
        public string ChildShortName { get; set; }
        public int GroupTypeId { get; set; }
        public string GroupTypeName { get; set; }
        public string GroupName { get; set; }
        public int? Code { get; set; }
    }
}
