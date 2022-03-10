using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDocument
    {
        public AccountDocument()
        {
            AccountDocumentDynamicParameters = new HashSet<AccountDocumentDynamicParameter>();
            AccountDocumentServiceTypes = new HashSet<AccountDocumentServiceType>();
        }

        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }
        public int StatusDocumentId { get; set; }
        public DateTime FromDate { get; set; }
        public long OrgDocumentId { get; set; }
        public DateTime? ToDate { get; set; }
        public long? Servicetypeid { get; set; }
        public long? TypeDocumentId { get; set; }
        public string KodObj { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual OrgDocument OrgDocument { get; set; }
        public virtual ServiceType Servicetype { get; set; }
        public virtual FasetItem StatusDocument { get; set; }
        public virtual AccountTypeDocument TypeDocument { get; set; }
        public virtual ICollection<AccountDocumentDynamicParameter> AccountDocumentDynamicParameters { get; set; }
        public virtual ICollection<AccountDocumentServiceType> AccountDocumentServiceTypes { get; set; }
    }
}
