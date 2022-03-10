using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendingXmlToServiceView
    {
        public long Id { get; set; }
        public long? ParentId { get; set; }
        public string ReportNumber { get; set; }
        public string ServiceAddress { get; set; }
        public string AuthUserPasswd { get; set; }
        public int? CountDatas { get; set; }
        public string Xmldata { get; set; }
        public int? DataId { get; set; }
        public int? Response { get; set; }
        public int? ErrorMessage { get; set; }
        public int? CountResponses { get; set; }
        public DateTime? Created { get; set; }
    }
}
