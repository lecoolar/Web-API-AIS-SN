using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitDocument
    {
        public ServiceSplitDocument()
        {
            ServiceSplitPercents = new HashSet<ServiceSplitPercent>();
        }

        public long Id { get; set; }
        public long MainOrgDocumentId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public long OrganizationId { get; set; }
        public string Comment { get; set; }

        public virtual OrgDocument MainOrgDocument { get; set; }
        public virtual Organization1 Organization { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ServiceSplitPercent> ServiceSplitPercents { get; set; }
    }
}
