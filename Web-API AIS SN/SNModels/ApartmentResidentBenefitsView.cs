using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentBenefitsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public long PersonBenefitId { get; set; }
        public long PersonBenefitOwnerId { get; set; }
        public string PersonBenefitOwnerName { get; set; }
        public long BenefitId { get; set; }
        public string BenefitName { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal? PercentServiceTypes { get; set; }
        public int? FamilyFasetId { get; set; }
        public string FamilyFasetName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Birthdate { get; set; }
        public int? Age { get; set; }
        public bool IsUnknown { get; set; }
        public string CloseReason { get; set; }
    }
}
