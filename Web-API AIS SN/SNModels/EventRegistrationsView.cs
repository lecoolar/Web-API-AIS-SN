using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class EventRegistrationsView
    {
        public long Id { get; set; }
        public long ObjectId { get; set; }
        public string TableName { get; set; }
        public long EventTypeId { get; set; }
        public string EventTypeName { get; set; }
        public long UserId { get; set; }
        public bool IsProcessed { get; set; }
        public DateTime Created { get; set; }
    }
}
