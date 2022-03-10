using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class MeetingsView
    {
        public long MeetingId { get; set; }
        public string NameTopic { get; set; }
        public int Status { get; set; }
        public string HouseFiasCode { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateBeginAbsenteeMeeting { get; set; }
        public DateTime DateBeginIntramuralMeeting { get; set; }
        public DateTime DateEndMeeting { get; set; }
        public string StatusName { get; set; }
        public long FiasNameWebServicesId { get; set; }
        public long RiasId { get; set; }
    }
}
