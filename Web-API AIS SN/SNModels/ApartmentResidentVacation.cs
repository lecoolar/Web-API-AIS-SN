using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentResidentVacation
    {
        public ApartmentResidentVacation()
        {
            ApartmentResidentVacationServiceTypes = new HashSet<ApartmentResidentVacationServiceType>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public long ResidentId { get; set; }
        public int? VacationFasetId { get; set; }
        public DateTime? DateDoc { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string Comment { get; set; }
        public bool IsForControl { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual ApartmentResident Resident { get; set; }
        public virtual FasetItem VacationFaset { get; set; }
        public virtual ICollection<ApartmentResidentVacationServiceType> ApartmentResidentVacationServiceTypes { get; set; }
    }
}
