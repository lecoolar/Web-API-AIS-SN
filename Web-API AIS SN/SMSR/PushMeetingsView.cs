using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PushMeetingsView
    {
        public long PushMeetingId { get; set; }
        public string NameTopic { get; set; }
        public int Status { get; set; }
        public string HouseFiasCode { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateBeginAbsenteeMeeting { get; set; }
        public DateTime DateBeginIntramuralMeeting { get; set; }
        public DateTime DateEndMeeting { get; set; }
        public string StatusName { get; set; }
    }
}
