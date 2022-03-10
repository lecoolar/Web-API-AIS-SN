using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocumentTypeDoc
    {
        public long Id { get; set; }
        public long OrgDocumentId { get; set; }
        public long TypeDocId { get; set; }

        public virtual OrgDocument OrgDocument { get; set; }
        public virtual AccountTypeDocument TypeDoc { get; set; }
    }
}
