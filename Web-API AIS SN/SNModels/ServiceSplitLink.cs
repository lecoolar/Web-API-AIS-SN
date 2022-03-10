using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitLink
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public long HouseHolderId { get; set; }
        public long OrgDocId { get; set; }
        public DateTime Created { get; set; }

        public virtual Organization1 HouseHolder { get; set; }
        public virtual OrgDocument OrgDoc { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
