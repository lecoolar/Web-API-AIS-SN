using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RemitteeService
    {
        public long Id { get; set; }
        public long RemitteeId { get; set; }
        public long ServiceId { get; set; }
        public DateTime FromDate { get; set; }
        public bool IsRemitteeCommission { get; set; }

        public virtual Remittee Remittee { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
