using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitBalance
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public long OrgDocId { get; set; }
        public DateTime OnEndOfDate { get; set; }
        public decimal Balance { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual OrgDocument OrgDoc { get; set; }
    }
}
