using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDocumentServiceType
    {
        public long Id { get; set; }
        public long AccountdocumentId { get; set; }
        public long Servicetypeid { get; set; }

        public virtual AccountDocument Accountdocument { get; set; }
    }
}
