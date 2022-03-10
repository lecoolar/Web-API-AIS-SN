using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceCommission
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public decimal Commission { get; set; }
        public long? DocId { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }

        public virtual OrgDocument Doc { get; set; }
        public virtual Service1 Service { get; set; }
    }
}
