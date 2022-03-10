using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitPercent
    {
        public long Id { get; set; }
        public long ServiceSplitDocumentId { get; set; }
        public long OrgDocumentId { get; set; }
        public decimal Percent { get; set; }
        public bool ApplyPaymentPercentHere { get; set; }

        public virtual OrgDocument OrgDocument { get; set; }
        public virtual ServiceSplitDocument ServiceSplitDocument { get; set; }
    }
}
