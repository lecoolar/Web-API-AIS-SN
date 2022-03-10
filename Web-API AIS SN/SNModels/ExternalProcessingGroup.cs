using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingGroup
    {
        public ExternalProcessingGroup()
        {
            ExternalProcessingTemplates = new HashSet<ExternalProcessingTemplate>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ExternalProcessingTemplate> ExternalProcessingTemplates { get; set; }
    }
}
