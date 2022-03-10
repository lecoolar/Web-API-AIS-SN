using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocumentsEventLogsView
    {
        public long Id { get; set; }
        public long? OrgDocumentId { get; set; }
        public string OrgDocumentNumber { get; set; }
        public DateTime? OrgDocumentIssueDate { get; set; }
        public int TypeEvent { get; set; }
        public string TypeEventName { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime? DocumentCreated { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
    }
}
