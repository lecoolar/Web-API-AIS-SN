using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EventRegistration
    {
        public long Id { get; set; }
        public long ObjectId { get; set; }
        public long EventTypeId { get; set; }
        public long UserId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime Created { get; set; }
        public int? UsageTypeId { get; set; }

        public virtual EventType EventType { get; set; }
        public virtual FasetItem UsageType { get; set; }
        public virtual User User { get; set; }
    }
}
