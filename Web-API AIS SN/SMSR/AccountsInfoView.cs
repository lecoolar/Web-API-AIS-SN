using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class AccountsInfoView
    {
        public string Accountnumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string FiasCode { get; set; }
        public long BaseId { get; set; }
        public string BaseName { get; set; }
        public string Area { get; set; }
        public long? ApartmentId { get; set; }
    }
}
