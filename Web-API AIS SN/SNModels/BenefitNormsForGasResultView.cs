using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitNormsForGasResultView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public long? BenefitId { get; set; }
        public string BenefitName { get; set; }
        public int TypeId { get; set; }
        public int? ExceptTypeId { get; set; }
        public decimal Value { get; set; }
        public string TypeName { get; set; }
        public string ExceptTypeName { get; set; }
        public short FasetId { get; set; }
        public string FasetName { get; set; }
        public short? ExceptFasetId { get; set; }
        public string ExceptFasetName { get; set; }
    }
}
