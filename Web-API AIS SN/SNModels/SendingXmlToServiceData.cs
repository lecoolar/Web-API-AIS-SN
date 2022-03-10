using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendingXmlToServiceData
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Data { get; set; }
        public string Response { get; set; }
        public string ErrorMessage { get; set; }
    }
}
