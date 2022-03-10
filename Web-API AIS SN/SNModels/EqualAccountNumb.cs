using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EqualAccountNumb
    {
        public string BillOrg { get; set; }
        public string SubDiv { get; set; }
        public DateTime? Period { get; set; }
        public string Number { get; set; }
        public string ProvNumber { get; set; }
        public long? Billid { get; set; }
        public long? SubdivId { get; set; }
    }
}
