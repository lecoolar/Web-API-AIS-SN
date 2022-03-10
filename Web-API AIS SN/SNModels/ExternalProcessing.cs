using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExternalProcessing
    {
        public ExternalProcessing()
        {
            BankPaymentOrderRecordExternalProcessings = new HashSet<BankPaymentOrderRecordExternalProcessing>();
            ExternalProcessingFileRecords = new HashSet<ExternalProcessingFileRecord>();
            ExternalProcessingParameters = new HashSet<ExternalProcessingParameter>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long ProcessingTemplateId { get; set; }
        public long? UserId { get; set; }
        public int Status { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }

        public virtual ExternalProcessingTemplate ProcessingTemplate { get; set; }
        public virtual ICollection<BankPaymentOrderRecordExternalProcessing> BankPaymentOrderRecordExternalProcessings { get; set; }
        public virtual ICollection<ExternalProcessingFileRecord> ExternalProcessingFileRecords { get; set; }
        public virtual ICollection<ExternalProcessingParameter> ExternalProcessingParameters { get; set; }
    }
}
