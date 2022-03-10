using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebService
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string UnitName { get; set; }
        public string TypeName { get; set; }
    }
}
