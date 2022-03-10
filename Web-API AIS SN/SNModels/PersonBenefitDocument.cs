using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PersonBenefitDocument
    {
        public long Id { get; set; }
        public long PersonBenefitId { get; set; }
        public int? TypeDoc { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public string WhereDoc { get; set; }
        public long? OrgId { get; set; }
        public string NumNotif { get; set; }
        public DateTime? DateNotif { get; set; }
        public string OrgNotif { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string CloseReason { get; set; }

        public virtual Organization1 Org { get; set; }
        public virtual PersonBenefit PersonBenefit { get; set; }
        public virtual FasetItem TypeDocNavigation { get; set; }
    }
}
