using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportGroup
    {
        public ReportGroup()
        {
            ReportTemplates = new HashSet<ReportTemplate>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsGroupOperation { get; set; }

        public virtual ICollection<ReportTemplate> ReportTemplates { get; set; }
    }
}
