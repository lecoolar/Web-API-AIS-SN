using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentHouseHoldersView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long OrgId { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public DateTime FromDate { get; set; }
    }
}
