using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentVacationServiceTypesView
    {
        public long Id { get; set; }
        public long ApartmentResidentVacationId { get; set; }
        public long ServiceTypeId { get; set; }
        public int? ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
    }
}
