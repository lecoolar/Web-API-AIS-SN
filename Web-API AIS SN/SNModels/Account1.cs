using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Account1
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public long ServiceProviderId { get; set; }
        public string Adr { get; set; }
        public string Phone { get; set; }
        public string DocNumber { get; set; }

        public virtual ServiceProvider ServiceProvider { get; set; }
        public virtual AccountDebt AccountDebt { get; set; }
    }
}
