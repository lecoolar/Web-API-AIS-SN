using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BenefitsGt
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public long? ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public long? BenefitId { get; set; }
        public string BenefitName { get; set; }
        public string BenefitCode { get; set; }
        public long? FasetBudgetTypeId { get; set; }
        public string FasetBudgetTypeName { get; set; }
        public long? LawId { get; set; }
        public string LawName { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public long? ServiceId { get; set; }
        public string ServiceName { get; set; }
        public long? PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PersonDocSer { get; set; }
        public string PersonDocNum { get; set; }
        public DateTime? PersonDocDate { get; set; }
        public string BenefitDocSer { get; set; }
        public string BenefitDocNum { get; set; }
        public string BenefitDocTypeName { get; set; }
        public DateTime? BenefitFromDate { get; set; }
        public DateTime? BenefitToDate { get; set; }
        public string PersonKey { get; set; }
        public string PersonApartmentKey { get; set; }
        public decimal? BenefitSumm { get; set; }
        public long? ExploitingPersonId { get; set; }
        public string ExploitingPersonKey { get; set; }
        public DateTime Created { get; set; }
        public string AccountNumber { get; set; }
        public decimal? BenefitChargeSumm { get; set; }
        public decimal? BenefitRecSumm { get; set; }
        public decimal? MonetizedBenefitChargeSumm { get; set; }
        public decimal? MonetizedBenefitRecSumm { get; set; }
        public long? UserId { get; set; }
    }
}
