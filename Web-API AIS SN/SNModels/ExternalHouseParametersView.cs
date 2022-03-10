using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalHouseParametersView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long OrgId { get; set; }
        public string FirstParam { get; set; }
        public string SecondParam { get; set; }
        public string ThirdParam { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int OrgCode { get; set; }
        public string OrgName { get; set; }
        public string OrgLongName { get; set; }
    }
}
