using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentBenefitPropertiesView
    {
        public long Id { get; set; }
        public long ApartmentResidentId { get; set; }
        public long? BankId { get; set; }
        public string BankName { get; set; }
        public int Kind { get; set; }
        public string KindName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
    }
}
