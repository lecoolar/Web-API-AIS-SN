using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitJn
    {
        public ServiceSplitJn()
        {
            ServiceSplitJnTransfers = new HashSet<ServiceSplitJnTransfer>();
        }

        public long Id { get; set; }
        public long JnId { get; set; }
        public DateTime JnDate { get; set; }
        public DateTime SplitDate { get; set; }
        public long TransferToOrgId { get; set; }
        public long? OrgDocId { get; set; }
        public string Comment { get; set; }
        public decimal Summ { get; set; }
        public bool IsRecalc { get; set; }
        public bool IsLiveMoney { get; set; }

        public virtual OrgDocument OrgDoc { get; set; }
        public virtual Organization1 TransferToOrg { get; set; }
        public virtual ICollection<ServiceSplitJnTransfer> ServiceSplitJnTransfers { get; set; }
    }
}
