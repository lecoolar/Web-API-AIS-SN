using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestAccountServiceFilterParametersView
    {
        public long Id { get; set; }
        public long FilterId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
