using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentVacationsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public long ResidentId { get; set; }
        public string PersonName { get; set; }
        public int? VacationFasetId { get; set; }
        public string VacationFasetName { get; set; }
        public DateTime? DateDoc { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string Comment { get; set; }
        public bool IsForControl { get; set; }
    }
}
