using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseOuterInformation
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long OrganizationId { get; set; }
        public string Field { get; set; }
        public DateTime FromDate { get; set; }

        public virtual House House { get; set; }
        public virtual Organization1 Organization { get; set; }
    }
}
