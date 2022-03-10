using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypesSynonym
    {
        public long Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
    }
}
