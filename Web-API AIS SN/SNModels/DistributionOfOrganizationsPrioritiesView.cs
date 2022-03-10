using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DistributionOfOrganizationsPrioritiesView
    {
        public long Id { get; set; }
        public long AccountHouseHolderId { get; set; }
        public int AccountHouseHolderCode { get; set; }
        public string AccountHouseHolderName { get; set; }
        public long ServiceOrganizationId { get; set; }
        public int ServiceOrganizationCode { get; set; }
        public string ServiceOrganizationName { get; set; }
        public int Priority { get; set; }
        public bool? IsHouseHolder { get; set; }
        public bool? IsServiceProvider { get; set; }
    }
}
