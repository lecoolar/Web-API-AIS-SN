using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitTransfersView
    {
        public long Id { get; set; }
        public DateTime TransferDate { get; set; }
        public long TransferToOrgId { get; set; }
        public int OrgCode { get; set; }
        public string OrgShortName { get; set; }
        public string OrgLongName { get; set; }
        public long? OrgInn { get; set; }
        public long? OrgKpp { get; set; }
        public long? OrgDocId { get; set; }
        public string DocTypeName { get; set; }
        public string DocNumber { get; set; }
        public DateTime DocIssueDate { get; set; }
        public string DocComment { get; set; }
        public string OrgDocumentName { get; set; }
        public string Comment { get; set; }
        public decimal Summ { get; set; }
        public bool IsRecalc { get; set; }
        public bool IsExported { get; set; }
    }
}
