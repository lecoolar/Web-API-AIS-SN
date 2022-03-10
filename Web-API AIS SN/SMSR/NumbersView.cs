using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class NumbersView
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Owner { get; set; }
        public string PersonInn { get; set; }
        public string PersonSnils { get; set; }
        public string Email { get; set; }
    }
}
