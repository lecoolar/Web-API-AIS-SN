using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServicesViewForLk
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public string ServiceShortName { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string UnitName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string OrgName { get; set; }
        public decimal? CurrentRate { get; set; }
        public long AccountId { get; set; }
    }
}
