using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DocumentService
    {
        public DocumentService()
        {
            DocumentServiceOrgs = new HashSet<DocumentServiceOrg>();
        }

        public long Id { get; set; }
        public int TypeId { get; set; }
        public string Number { get; set; }
        public long ServiceId { get; set; }
        public long AgentId { get; set; }
        public decimal? MaxSumm { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Organization1 Agent { get; set; }
        public virtual Service2 Service { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual ICollection<DocumentServiceOrg> DocumentServiceOrgs { get; set; }
    }
}
