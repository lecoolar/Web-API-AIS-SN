using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class FiasNameWebServicesView
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string NameWebService { get; set; }
        public string Accnumber { get; set; }
        public string Room { get; set; }
        public long? ApartmentId { get; set; }
        public string Area { get; set; }
        public string LocalAddresses { get; set; }
    }
}
