using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterBetweenCheckIntervalsView
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public DateTime? PrevCheckDate { get; set; }
        public DateTime NextCheckDate { get; set; }
        public long? OrgId { get; set; }
        public string Comment { get; set; }
        public long UserId { get; set; }
        public DateTime Created { get; set; }
        public string OrganizationShortName { get; set; }
        public string UserName { get; set; }
    }
}
