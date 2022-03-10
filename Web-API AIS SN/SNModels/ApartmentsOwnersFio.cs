using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentsOwnersFio
    {
        public string Fio { get; set; }
        public DateTime? BirthDate { get; set; }
        public long PersonId { get; set; }
        public long OwnerId { get; set; }
        public long ApartmentId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ApOwDatec { get; set; }
    }
}
