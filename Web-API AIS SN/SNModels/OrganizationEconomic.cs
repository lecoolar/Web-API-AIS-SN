using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationEconomic
    {
        public long Id { get; set; }
        public long ServiceTypeId { get; set; }
        public int Characteristic { get; set; }
        public decimal Value { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime Datee { get; set; }
        public long OrgId { get; set; }
        public DateTime Datec { get; set; }
    }
}
