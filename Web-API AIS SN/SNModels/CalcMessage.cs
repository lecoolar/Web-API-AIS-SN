using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcMessage
    {
        public int Id { get; set; }
        public long? CalcId { get; set; }
        public string CalcMessage1 { get; set; }
    }
}
