using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportTemplateBu
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string Sql { get; set; }
    }
}
