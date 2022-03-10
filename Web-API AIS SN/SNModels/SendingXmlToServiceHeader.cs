using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendingXmlToServiceHeader
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string ServiceAddress { get; set; }
        public string AuthUserPasswd { get; set; }
        public DateTime? Created { get; set; }
    }
}
