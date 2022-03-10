using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceDocumentsView
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public long? DocumentId { get; set; }
        public string AccountNumber { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public string DocTypeName { get; set; }
        public string DocNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
