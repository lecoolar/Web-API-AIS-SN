using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypesWithBenefitSrvTypeLinkView
    {
        public long Id { get; set; }
        public int? Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int? UnitId { get; set; }
        public long? ClT { get; set; }
        public long? ObjT { get; set; }
        public long? ParentId { get; set; }
        public int IsGroup { get; set; }
        public long BenefitServiceTypeId { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public string ExternalCode { get; set; }
        public int? ExternalCodeId { get; set; }
    }
}
