using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceBinding
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceBenefitName { get; set; }
    }
}
