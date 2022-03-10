using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountsView1
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public long ServiceProviderId { get; set; }
        public string Adr { get; set; }
        public string Phone { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public long OrgId { get; set; }
        public string OrgName { get; set; }
        public long? SnOrgId { get; set; }
        public string SnOrgName { get; set; }
    }
}
