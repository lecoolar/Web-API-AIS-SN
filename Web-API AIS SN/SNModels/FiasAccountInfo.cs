using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FiasAccountInfo
    {
        public long LocalAddresses { get; set; }
        public long ApartmentId { get; set; }
        public string FiasCode { get; set; }
        public string AccountNumber { get; set; }
        public string Room { get; set; }
    }
}
