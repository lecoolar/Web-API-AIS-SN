using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Counter
    {
        public string Code { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Objectcode { get; set; }
        public string EnergyResource { get; set; }
        public string Prefix { get; set; }
        public string Number { get; set; }
        public int? Scale { get; set; }
        public int? CountScale { get; set; }
        public int? Capacity { get; set; }
        public decimal? Koefficient { get; set; }
        public string Model { get; set; }
        public DateTime? DateVerification { get; set; }
        public long? ResourceCounterGroup { get; set; }
        public decimal? LastVal { get; set; }
        public DateTime? LastValDate { get; set; }
        public string SlavedNumber { get; set; }
        public string Comment { get; set; }
        public long? Loadid { get; set; }
        public long? LastLoadActive { get; set; }
        public DateTime? Created { get; set; }
        public bool ForcedIgnore { get; set; }

        public virtual Load LastLoadActiveNavigation { get; set; }
        public virtual Load Load { get; set; }
    }
}
