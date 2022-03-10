using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebPaymentDocumentServiceGroup
    {
        public long Code { get; set; }
        public string Name { get; set; }
        public long? MinServiceTypeId { get; set; }
        public long? MaxServiceTypeId { get; set; }
        public DateTime? Created { get; set; }
        public string UnitName { get; set; }
    }
}
