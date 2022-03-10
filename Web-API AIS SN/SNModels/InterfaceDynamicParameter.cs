using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class InterfaceDynamicParameter
    {
        public InterfaceDynamicParameter()
        {
            AccountDocumentDynamicParameters = new HashSet<AccountDocumentDynamicParameter>();
        }

        public long Id { get; set; }
        public int ParentTypeId { get; set; }
        public long ParentId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public int Sort { get; set; }
        public string PrintType { get; set; }
        public string SubType { get; set; }

        public virtual FasetItem ParentType { get; set; }
        public virtual ICollection<AccountDocumentDynamicParameter> AccountDocumentDynamicParameters { get; set; }
    }
}
