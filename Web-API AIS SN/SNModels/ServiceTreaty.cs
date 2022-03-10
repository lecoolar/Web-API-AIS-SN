using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTreaty
    {
        public long Id { get; set; }
        public long AdrId { get; set; }
        public decimal Tariff { get; set; }
        public decimal Count { get; set; }
        public decimal Summ { get; set; }
        public long TreatieId { get; set; }

        public virtual LocalAddress Adr { get; set; }
        public virtual Treaty Treatie { get; set; }
    }
}
