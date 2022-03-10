using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountTypeDocument
    {
        public AccountTypeDocument()
        {
            AccountDocuments = new HashSet<AccountDocument>();
            OrgDocumentTypeDocs = new HashSet<OrgDocumentTypeDoc>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? ReportTemplateId { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual ICollection<AccountDocument> AccountDocuments { get; set; }
        public virtual ICollection<OrgDocumentTypeDoc> OrgDocumentTypeDocs { get; set; }
    }
}
