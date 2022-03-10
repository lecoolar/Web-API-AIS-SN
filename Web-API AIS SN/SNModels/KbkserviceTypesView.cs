using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class KbkserviceTypesView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public int? FasetItem161Id { get; set; }
        public int? FasetItem162Id { get; set; }
        public int? FasetItem163Id { get; set; }
        public string FasetConsumerGroups { get; set; }
        public string FasetExternalServiceTypes { get; set; }
        public string FasetKbkarticles { get; set; }
        public string Name { get; set; }
    }
}
