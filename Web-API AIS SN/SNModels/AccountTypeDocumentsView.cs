using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountTypeDocumentsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ReportTemplateId { get; set; }
        public string ReportTemplateName { get; set; }
    }
}
