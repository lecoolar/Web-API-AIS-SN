using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentVacationServiceType
    {
        public long Id { get; set; }
        public long ApartmentResidentVacationId { get; set; }
        public long ServiceTypeId { get; set; }

        public virtual ApartmentResidentVacation ApartmentResidentVacation { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
