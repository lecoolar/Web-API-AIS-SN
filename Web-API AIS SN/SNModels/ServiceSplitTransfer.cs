using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitTransfer
    {
        public long Id { get; set; }
        public DateTime TransferDate { get; set; }
        public long TransferToOrgId { get; set; }
        public long? OrgDocId { get; set; }
        public string Comment { get; set; }
        public decimal Summ { get; set; }
        public bool IsRecalc { get; set; }
        public bool IsExported { get; set; }

        public virtual OrgDocument OrgDoc { get; set; }
        public virtual Organization1 TransferToOrg { get; set; }
    }
}
