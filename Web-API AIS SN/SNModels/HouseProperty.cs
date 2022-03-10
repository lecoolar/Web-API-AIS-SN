using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseProperty
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public int PropertyId { get; set; }
        public long? DocId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }
        public string Value { get; set; }

        public virtual OrgDocument Doc { get; set; }
        public virtual House House { get; set; }
        public virtual FasetItem Property { get; set; }
    }
}
