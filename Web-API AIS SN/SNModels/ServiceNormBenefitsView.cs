using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceNormBenefitsView
    {
        public long Id { get; set; }
        public long? ServiceId { get; set; }
        public long BenefitId { get; set; }
        public decimal Rate { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
    }
}
