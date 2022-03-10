using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceNorm
    {
        public ServiceNorm()
        {
            ServiceNormTypes = new HashSet<ServiceNormType>();
        }

        public long Id { get; set; }
        public long ServiceId { get; set; }
        public decimal Rate { get; set; }
        public int UnitId { get; set; }
        public int? ByUnitId { get; set; }
        public long? DocId { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public decimal? FromValue { get; set; }
        public decimal? ToValue { get; set; }
        public int AppartmentType { get; set; }

        public virtual FasetItem ByUnit { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual FasetItem Unit { get; set; }
        public virtual ICollection<ServiceNormType> ServiceNormTypes { get; set; }
    }
}
