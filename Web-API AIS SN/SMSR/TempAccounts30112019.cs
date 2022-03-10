using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class TempAccounts30112019
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public long WebServiceId { get; set; }
        public string OwnerName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? Status { get; set; }
        public string Comment { get; set; }
        public string TypeRegistration { get; set; }
    }
}
