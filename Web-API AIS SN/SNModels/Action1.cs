using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Action1
    {
        public Action1()
        {
            ActionInsertedObjects = new HashSet<ActionInsertedObject>();
            ActionLogs = new HashSet<ActionLog>();
        }

        public long Id { get; set; }
        public int? GroupFasetId { get; set; }
        public DateTime Created { get; set; }
        public long? CanceledAction { get; set; }
        public long? ObjectId { get; set; }
        public int? ObjectTypeFasetId { get; set; }
        public long? UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ActionInsertedObject> ActionInsertedObjects { get; set; }
        public virtual ICollection<ActionLog> ActionLogs { get; set; }
    }
}
