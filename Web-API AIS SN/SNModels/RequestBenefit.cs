using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestBenefit
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public string BenefitName { get; set; }
        public byte PersonsCount { get; set; }
    }
}
