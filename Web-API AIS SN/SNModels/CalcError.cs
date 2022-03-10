using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcError
    {
        public long? CalcId { get; set; }
        public string ObjType { get; set; }
        public string Obj { get; set; }
        public string Error { get; set; }
        public long? CounterId { get; set; }
    }
}
