using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonFamilyView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long FromPersonId { get; set; }
        public string FromPersonName { get; set; }
        public long ToPersonId { get; set; }
        public string ToPersonName { get; set; }
        public int? RelationId { get; set; }
        public string RelationName { get; set; }
    }
}
