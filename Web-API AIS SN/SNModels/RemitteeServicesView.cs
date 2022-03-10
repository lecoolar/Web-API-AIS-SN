using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RemitteeServicesView
    {
        public long Id { get; set; }
        public long RemitteeId { get; set; }
        public string RemitteeOrgShortName { get; set; }
        public int RemitteeOrgCode { get; set; }
        public string RemitteeClientDocNumber { get; set; }
        public string RemitteeClientDocOrgName { get; set; }
        public bool IsRemitteeCommission { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public DateTime FromDate { get; set; }
        public string Comment { get; set; }
    }
}
