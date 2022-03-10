using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ApartmentLsNumberFia
    {
        public long Id { get; set; }
        public long? FiasNameWebServicesId { get; set; }
        public long? ApartmentId { get; set; }
        public string Room { get; set; }
        public string Accnumber { get; set; }
        public string LocalAddresses { get; set; }

        public virtual FiasNameWebService FiasNameWebServices { get; set; }
    }
}
