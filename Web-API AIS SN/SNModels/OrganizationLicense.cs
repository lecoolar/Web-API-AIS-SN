using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationLicense
    {
        public long Id { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public int TypeId { get; set; }
        public long OrgId { get; set; }
        public int? LicensOrgTypeId { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
