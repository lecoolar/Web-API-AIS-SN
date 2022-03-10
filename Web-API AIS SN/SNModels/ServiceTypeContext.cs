using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeContext
    {
        public short Id { get; set; }
        public long? ServiceTypeId { get; set; }
        public int? TypeContextId { get; set; }

        public virtual ServiceType ServiceType { get; set; }
        public virtual FasetItem TypeContext { get; set; }
    }
}
