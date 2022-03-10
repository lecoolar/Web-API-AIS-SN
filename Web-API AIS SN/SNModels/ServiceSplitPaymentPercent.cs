using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitPaymentPercent
    {
        public long Id { get; set; }
        public long OrgDocumentId { get; set; }
        public decimal Percent { get; set; }
        public DateTime FromDate { get; set; }

        public virtual OrgDocument OrgDocument { get; set; }
    }
}
