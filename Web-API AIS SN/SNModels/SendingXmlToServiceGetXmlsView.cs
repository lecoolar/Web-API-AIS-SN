using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class SendingXmlToServiceGetXmlsView
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string ReportNumber { get; set; }
        public string ServiceAddress { get; set; }
        public string AuthUserPasswd { get; set; }
        public int CountDatas { get; set; }
        public string Xmldata { get; set; }
        public long? DataId { get; set; }
        public string Response { get; set; }
        public string ErrorMessage { get; set; }
        public int CountResponses { get; set; }
        public DateTime? Created { get; set; }
    }
}
