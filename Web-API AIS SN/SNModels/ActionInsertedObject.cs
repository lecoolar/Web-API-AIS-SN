using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionInsertedObject
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public int TableId { get; set; }
        public long ObjectId { get; set; }

        public virtual Action1 Action { get; set; }
        public virtual Table Table { get; set; }
    }
}
