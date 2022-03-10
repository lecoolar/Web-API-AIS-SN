using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocumentsEventLog
    {
        public long Id { get; set; }
        public long? OrgDocumentId { get; set; }
        public int TypeEvent { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentCreated { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }

        public virtual OrgDocument OrgDocument { get; set; }
        public virtual FasetItem TypeEventNavigation { get; set; }
    }
}
