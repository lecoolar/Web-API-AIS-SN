using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class QuestionAnswer
    {
        public long Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool? Show { get; set; }
    }
}
