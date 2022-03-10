using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonByOrganization
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long OrgId { get; set; }
        public int? TypeDoc { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string OrgDoc { get; set; }
        public string InsuranceCertificate { get; set; }
        public string AccountBenefit { get; set; }
        public DateTime? DateBenefit { get; set; }
        public long? OrgBenefitId { get; set; }
        public string BirthPlace { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? DateChange { get; set; }
        public string Inn { get; set; }
        public string SubdivisionCodeDoc { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int? Sex { get; set; }
        public string Comment { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual Organization1 OrgBenefit { get; set; }
        public virtual Person Person { get; set; }
        public virtual FasetItem SexNavigation { get; set; }
        public virtual FasetItem TypeDocNavigation { get; set; }
    }
}
