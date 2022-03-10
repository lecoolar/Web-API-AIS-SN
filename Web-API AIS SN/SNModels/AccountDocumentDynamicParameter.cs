using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDocumentDynamicParameter
    {
        public int Id { get; set; }
        public long AccountDocumentId { get; set; }
        public long InterfaceDynamicParameterId { get; set; }
        public string Value { get; set; }

        public virtual AccountDocument AccountDocument { get; set; }
        public virtual InterfaceDynamicParameter InterfaceDynamicParameter { get; set; }
    }
}
