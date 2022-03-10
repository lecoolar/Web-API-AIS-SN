using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceNorm
    {
        public HouseServiceNorm()
        {
            HouseServiceNormTypes = new HashSet<HouseServiceNormType>();
        }

        public long Id { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public long? ServiceId { get; set; }
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

        public virtual FasetItem AppartmentTypeNavigation { get; set; }
        public virtual FasetItem ByUnit { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual House House { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual FasetItem Unit { get; set; }
        public virtual ICollection<HouseServiceNormType> HouseServiceNormTypes { get; set; }
    }
}
