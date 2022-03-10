using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestGroup
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedByUserName { get; set; }
        public string Information { get; set; }
        public DateTime? PeriodExecution { get; set; }
        public string DeclarantShortName { get; set; }
        public string Ogrn { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string AddrName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
