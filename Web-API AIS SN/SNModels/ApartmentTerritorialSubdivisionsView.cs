using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentTerritorialSubdivisionsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long OrgId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public string ApartmentNumber { get; set; }
        public string OrganizationName { get; set; }
        public int OrganizationCode { get; set; }
    }
}
