using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitNormsForGa
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public long? BenefitId { get; set; }
        public int TypeId { get; set; }
        public int? ExceptTypeId { get; set; }
        public decimal Value { get; set; }

        public virtual Benefit1 Benefit { get; set; }
        public virtual FasetItem ExceptType { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
