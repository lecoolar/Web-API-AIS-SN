using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportDocument
    {
        public long Id { get; set; }
        public long ExportOperationId { get; set; }
        public bool IsExported { get; set; }
        public bool IsPrepared { get; set; }
        public long? AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual ExportOperation ExportOperation { get; set; }
    }
}
