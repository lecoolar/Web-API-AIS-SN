using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceDocument
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public long? DocumentId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual OrgDocument Document { get; set; }
    }
}
