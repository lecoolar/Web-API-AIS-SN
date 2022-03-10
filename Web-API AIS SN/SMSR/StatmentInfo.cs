using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class StatmentInfo
    {
        public long Id { get; set; }
        public string Fio { get; set; }
        public string Address { get; set; }
        public string PSeries { get; set; }
        public string PNumber { get; set; }
        public string Issued { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
    }
}
