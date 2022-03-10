using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitNormsForSquare
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? BenefitId { get; set; }
        public int FromResidents { get; set; }
        public int ToResidents { get; set; }
        public decimal Value { get; set; }
        public int FromRooms { get; set; }
        public int ToRooms { get; set; }

        public virtual Benefit1 Benefit { get; set; }
    }
}
