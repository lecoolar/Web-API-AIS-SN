using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentInfo
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public int? UniqueResidents { get; set; }
        public int? UniqueResidentVacations { get; set; }
        public int? UniqueResidentNotAllVacations { get; set; }
        public int? OnEndResidents { get; set; }
        public int? OnEndResidentVacations { get; set; }
        public int? OnEndResidentNotVacations { get; set; }
        public int? ResidentDaysAll { get; set; }
        public int? ResidentDaysVacation { get; set; }
        public int? ResidentDaysNotVacation { get; set; }
        public decimal? ResidentMonthsAll { get; set; }
        public decimal? ResidentMonthsVacation { get; set; }
        public decimal? ResidentMonthsNotVacation { get; set; }
        public int? UniqueOwners { get; set; }
        public int? OnEndOwners { get; set; }
        public int? OwnerDays { get; set; }
        public decimal? OwnerMonths { get; set; }
        public int Min1Resident { get; set; }
    }
}
