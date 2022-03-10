using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitLinksView
    {
        public long Id { get; set; }
        public long OrgDocId { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public long HouseHolderId { get; set; }
        public string OrganizationName { get; set; }
        public DateTime Created { get; set; }
        public string OrgDocumentName { get; set; }
    }
}
