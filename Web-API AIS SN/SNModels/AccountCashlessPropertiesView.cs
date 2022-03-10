using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountCashlessPropertiesView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long? OrgId { get; set; }
        public string OrgName { get; set; }
        public long? PersonId { get; set; }
        public string PersonName { get; set; }
        public string PrintName { get; set; }
        public string Number { get; set; }
        public string Subdivision { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
