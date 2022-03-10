using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingTemplateParameter
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public long ProcessingTemplateId { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsUserVisible { get; set; }
        public string SubType { get; set; }

        public virtual ExternalProcessingTemplate ProcessingTemplate { get; set; }
    }
}
