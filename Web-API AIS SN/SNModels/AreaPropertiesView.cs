using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaPropertiesView
    {
        public long Id { get; set; }
        public int PropertyId { get; set; }
        public long AreaId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
