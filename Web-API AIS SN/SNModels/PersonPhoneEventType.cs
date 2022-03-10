using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonPhoneEventType
    {
        public long Id { get; set; }
        public long PersonPhoneId { get; set; }
        public long EventTypeId { get; set; }

        public virtual EventType1 EventType { get; set; }
        public virtual PersonPhone PersonPhone { get; set; }
    }
}
