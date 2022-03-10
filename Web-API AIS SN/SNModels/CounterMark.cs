using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CounterMark
    {
        public CounterMark()
        {
            ApartmentCounters = new HashSet<ApartmentCounter>();
            CounterModels = new HashSet<CounterModel>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int? TypeId { get; set; }
        public int? UnitId { get; set; }
        public int? Rzrd { get; set; }
        public decimal? ClMark { get; set; }
        public decimal? ObjMark { get; set; }

        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
        public virtual ICollection<CounterModel> CounterModels { get; set; }
    }
}
