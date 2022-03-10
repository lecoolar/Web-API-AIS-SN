using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDocumentsView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long OrgDocumentId { get; set; }
        public string Number { get; set; }
        public DateTime IssueDate { get; set; }
        public string OrgDocumentType { get; set; }
        public string DocumentComment { get; set; }
        public int StatusDocumentId { get; set; }
        public string StatusDocumentName { get; set; }
        public long? TypeDocumentId { get; set; }
        public string TypeDocumentName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime Created { get; set; }
        public long? Servicetypeid { get; set; }
        public int? Servicetypecode { get; set; }
        public string Servicetypeshortname { get; set; }
        public string Servicetypelongname { get; set; }
        public string OrgDocumentKodObj { get; set; }
    }
}
