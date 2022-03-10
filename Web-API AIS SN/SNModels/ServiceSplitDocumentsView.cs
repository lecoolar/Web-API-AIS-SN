using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitDocumentsView
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public string Comment { get; set; }
        public long MainOrgDocumentId { get; set; }
        public long OrganizationId { get; set; }
        public string MainProviderDocName { get; set; }
        public long MainProviderId { get; set; }
        public string MainProviderName { get; set; }
        public string MainProviderNumber { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string OrgName { get; set; }
    }
}
