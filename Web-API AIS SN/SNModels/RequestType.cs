using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestType
    {
        public RequestType()
        {
            Requests = new HashSet<Request>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public string ViewRequestProcName { get; set; }
        public string ProcessRequestProcName { get; set; }
        public string ViewCurrentStateProcName { get; set; }
        public int? IsAutoProcess { get; set; }
        public string Code { get; set; }
        public int? TypeFormId { get; set; }
        public long? ExternalProcessingTemplateId { get; set; }
        public string UpdateStateRequestProcName { get; set; }
        public bool? IsPreview { get; set; }
        public string FillContentProcName { get; set; }
        public bool? IsShowProgress { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
