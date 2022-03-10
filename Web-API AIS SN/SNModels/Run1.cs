using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Run1
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsError { get; set; }
        public string ErrorText { get; set; }
    }
}
