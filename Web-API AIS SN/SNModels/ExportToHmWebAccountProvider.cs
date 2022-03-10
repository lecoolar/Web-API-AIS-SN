using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAccountProvider
    {
        public long TransportAccountProviderId { get; set; }
        public long RemoteAccountId { get; set; }
        public long RemoteOrganizationId { get; set; }
        public string OrgShortName { get; set; }
        public string AccountNumber { get; set; }
        public bool IsRkc { get; set; }
        public bool IsHh { get; set; }
        public bool IsProvider { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CloseDate { get; set; }
        public bool? IsRecovery { get; set; }
        public string AccountNumberGis { get; set; }
        public bool? IsKr { get; set; }
    }
}
