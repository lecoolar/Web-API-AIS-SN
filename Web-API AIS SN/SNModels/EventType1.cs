using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EventType1
    {
        public EventType1()
        {
            PersonPhoneEventTypes = new HashSet<PersonPhoneEventType>();
        }

        public long Id { get; set; }
        public string Event { get; set; }
        public string MessageTemplate { get; set; }
        public bool? IsPriority { get; set; }
        public int? TimeToSend { get; set; }
        public byte? IsEnable { get; set; }

        public virtual ICollection<PersonPhoneEventType> PersonPhoneEventTypes { get; set; }
    }
}
