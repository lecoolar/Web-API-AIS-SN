using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonPropertiesView
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int IsBedPatient { get; set; }
        public string IsBedPatientName { get; set; }
        public int IsUnemployedPensioner { get; set; }
        public string IsUnemployedPensionerName { get; set; }
        public int IsInvalid { get; set; }
        public string IsInvalidName { get; set; }
    }
}
