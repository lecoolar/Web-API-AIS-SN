using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class IpPhoneRequest
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Ip { get; set; }
        public string Account { get; set; }
        public DateTime Created { get; set; }
        public DateTime RequestTime { get; set; }
        public bool? Completed { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string UserLogin { get; set; }
    }
}
