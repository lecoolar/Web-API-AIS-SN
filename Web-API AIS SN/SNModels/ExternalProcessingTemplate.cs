using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingTemplate
    {
        public ExternalProcessingTemplate()
        {
            ExternalProcessingTemplateParameters = new HashSet<ExternalProcessingTemplateParameter>();
            ExternalProcessings = new HashSet<ExternalProcessing>();
        }

        public long Id { get; set; }
        public long GroupId { get; set; }
        public string Name { get; set; }
        public string Sql { get; set; }
        public string Format { get; set; }
        public bool HasOutputFile { get; set; }
        public bool? HasInputFile { get; set; }
        public string Encoding { get; set; }
        public bool HasAddressComparison { get; set; }
        public string PostProcessingProcedure { get; set; }
        public string ViewProcedure { get; set; }
        public bool IsChangeTabDelimiter { get; set; }
        public string Separator { get; set; }
        public bool IsArchive { get; set; }
        public bool LoadAsDbf { get; set; }
        public string EncodingOutputFile { get; set; }
        public bool IsPreview { get; set; }
        public bool? UseDbffast { get; set; }
        public string ColumnsList { get; set; }

        public virtual ExternalProcessingGroup Group { get; set; }
        public virtual ICollection<ExternalProcessingTemplateParameter> ExternalProcessingTemplateParameters { get; set; }
        public virtual ICollection<ExternalProcessing> ExternalProcessings { get; set; }
    }
}
