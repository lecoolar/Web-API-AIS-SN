using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EventType
    {
        public EventType()
        {
            EventRegistrations = new HashSet<EventRegistration>();
        }

        public long Id { get; set; }
        public string TableName { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
    }
}
