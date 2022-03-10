using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitNormsForElectric
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public long? BenefitId { get; set; }
        public int FromResidents { get; set; }
        public int ToResidents { get; set; }
        public int IsWithCooker { get; set; }
        public decimal Value { get; set; }
        public int? RoomsCountStart { get; set; }
        public int? RoomsCountEnd { get; set; }
        public int? ApartmentType { get; set; }

        public virtual FasetItem ApartmentTypeNavigation { get; set; }
        public virtual Benefit1 Benefit { get; set; }
    }
}
