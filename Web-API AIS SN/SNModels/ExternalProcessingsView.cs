using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessingsView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ProcessingTemplateId { get; set; }
        public string ProcessingTemplateName { get; set; }
        public string Sql { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public int Status { get; set; }
        public string Encoding { get; set; }
        public string Result { get; set; }
        public bool ProcessingTemplateIsChangeTabDelimiter { get; set; }
        public string ErrorMessage { get; set; }
        public string InputFileName { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public TimeSpan? ExecutionTime { get; set; }
    }
}
