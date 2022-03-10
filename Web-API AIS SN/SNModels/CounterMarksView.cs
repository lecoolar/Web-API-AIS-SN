using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CounterMarksView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public string TypeCounter { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
        public int? Rzrd { get; set; }
        public decimal? ClMark { get; set; }
        public decimal? ObjMark { get; set; }
    }
}
