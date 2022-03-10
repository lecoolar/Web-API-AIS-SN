using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonFamily
    {
        public long Id { get; set; }
        public long FromPersonId { get; set; }
        public long ToPersonId { get; set; }
        public int? RelationId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Person FromPerson { get; set; }
        public virtual FasetItem Relation { get; set; }
        public virtual Person ToPerson { get; set; }
    }
}
