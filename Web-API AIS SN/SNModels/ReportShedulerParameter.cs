using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportShedulerParameter
    {
        public long Id { get; set; }
        public long ReportId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string PrintName { get; set; }
        public string PrintValue { get; set; }
    }
}
