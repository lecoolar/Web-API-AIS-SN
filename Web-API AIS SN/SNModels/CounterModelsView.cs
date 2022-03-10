using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CounterModelsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long MarkId { get; set; }
        public string MarkName { get; set; }
    }
}
