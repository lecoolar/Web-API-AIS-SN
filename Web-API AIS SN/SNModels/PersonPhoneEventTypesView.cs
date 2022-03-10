using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonPhoneEventTypesView
    {
        public long Id { get; set; }
        public long PersonPhoneId { get; set; }
        public long? EventTypeId { get; set; }
        public string Event { get; set; }
        public bool? IsEvent { get; set; }
        public long EventId { get; set; }
    }
}
