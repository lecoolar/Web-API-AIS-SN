using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HousePropertiesView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long HouseAdrId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public int PropertyId { get; set; }
        public string PropertyValue { get; set; }
        public long? DocId { get; set; }
        public string DocName { get; set; }
        public string Number { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public DateTime? ToDate { get; set; }
        public string Value { get; set; }
    }
}
