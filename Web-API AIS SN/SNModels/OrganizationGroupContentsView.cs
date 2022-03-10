using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationGroupContentsView
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public int GroupCode { get; set; }
        public string GroupName { get; set; }
        public long? OrganizationId { get; set; }
    }
}
