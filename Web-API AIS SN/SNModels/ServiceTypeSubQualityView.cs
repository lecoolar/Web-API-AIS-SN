using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeSubQualityView
    {
        public long Id { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string ServiceTypeNameAlias { get; set; }
        public string Normativ { get; set; }
        public int? QualityTypeId { get; set; }
        public string QualityTypeName { get; set; }
        public string QualityName { get; set; }
        public string SuspensionRule { get; set; }
        public long OrgDocId { get; set; }
        public string OrgDocumentName { get; set; }
        public string Comment { get; set; }
        public bool IsArchive { get; set; }
    }
}
