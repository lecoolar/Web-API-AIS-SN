using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ErrorsView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Code { get; set; }
        public int Number { get; set; }
        public int Priority { get; set; }
        public string Message { get; set; }
        public string Recommendation { get; set; }
        public string TechnicalData { get; set; }
        public string CodeNumber { get; set; }
    }
}
