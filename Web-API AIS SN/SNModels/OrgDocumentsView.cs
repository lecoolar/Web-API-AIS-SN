using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocumentsView
    {
        public long Id { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Comment { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public string OrgDocumentName { get; set; }
        public string KodObj { get; set; }
        public int? OkvedType { get; set; }
        public string Okved { get; set; }
        public decimal? Summ { get; set; }
        public decimal? Volume { get; set; }
        public int? StatusEventLogId { get; set; }
        public string StatusEventLog { get; set; }
    }
}
