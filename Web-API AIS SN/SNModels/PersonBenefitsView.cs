using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefitsView
    {
        public long Id { get; set; }
        public long PersonBenefitId { get; set; }
        public long PersonId { get; set; }
        public string PersonName { get; set; }
        public long BenefitId { get; set; }
        public string BenefitCode { get; set; }
        public string BenefitName { get; set; }
        public long ApartmentId { get; set; }
        public int? TypeDocFasetId { get; set; }
        public string TypeDocName { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string WhereDoc { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public string NumNotif { get; set; }
        public DateTime? DateNotif { get; set; }
        public string OrgNotif { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string CloseReason { get; set; }
    }
}
