using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportOperation
    {
        public ExportOperation()
        {
            ExportDocuments = new HashSet<ExportDocument>();
        }

        public long Id { get; set; }
        public long AreaId { get; set; }
        public string ExportDirectory { get; set; }
        public DateTime Created { get; set; }
        public long UserId { get; set; }
        public bool IsCompleted { get; set; }

        public virtual Area Area { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ExportDocument> ExportDocuments { get; set; }
    }
}
