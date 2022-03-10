using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Meeting
    {
        public long Id { get; set; }
        public string NameTopic { get; set; }
        public int Status { get; set; }
        public string HouseFiasCode { get; set; }
        public string AddressHouse { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateBeginAbsenteeMeeting { get; set; }
        public DateTime DateBeginIntramuralMeeting { get; set; }
        public DateTime DateEndMeeting { get; set; }
        public long RiasId { get; set; }
    }
}
