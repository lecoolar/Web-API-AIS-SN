using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SessionsView
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Ip { get; set; }
        public string Host { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public string ArmName { get; set; }
        public long Spid { get; set; }
        public Guid ConnectionId { get; set; }
    }
}
