using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrgDocumentTypeDocsView
    {
        public long Id { get; set; }
        public long OrgDocumentId { get; set; }
        public string TypeDocName { get; set; }
        public long TypeDocId { get; set; }
    }
}
