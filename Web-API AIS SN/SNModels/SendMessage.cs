using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendMessage
    {
        public long Id { get; set; }
        public string MessageText { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public string ErrorText { get; set; }
        public string Phone { get; set; }
    }
}
