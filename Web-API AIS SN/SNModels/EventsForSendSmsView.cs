using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EventsForSendSmsView
    {
        public long Id { get; set; }
        public long EventTypeId { get; set; }
        public long ObjectId { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public string Guid { get; set; }
        public long? UserId { get; set; }
        public string Name { get; set; }
    }
}
