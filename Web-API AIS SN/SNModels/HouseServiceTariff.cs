using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceTariff
    {
        public HouseServiceTariff()
        {
            HouseServiceTariffTypes = new HashSet<HouseServiceTariffType>();
        }

        public long Id { get; set; }
        public long ServiceTypeId { get; set; }
        public long? ServiceId { get; set; }
        public decimal Rate { get; set; }
        public long? DocId { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long HouseId { get; set; }

        public virtual OrgDocument Doc { get; set; }
        public virtual House House { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<HouseServiceTariffType> HouseServiceTariffTypes { get; set; }
    }
}
