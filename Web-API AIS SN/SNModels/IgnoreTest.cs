using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class IgnoreTest
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public int? Number { get; set; }
        public string Reason { get; set; }
        public DateTime Created { get; set; }
    }
}
