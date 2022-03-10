using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ErrorLog
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Ls { get; set; }
        public string Place { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
