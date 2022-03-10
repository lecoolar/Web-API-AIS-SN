using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CounterModel
    {
        public CounterModel()
        {
            ApartmentCounters = new HashSet<ApartmentCounter>();
            HouseCounter2s = new HashSet<HouseCounter2>();
        }

        public long Id { get; set; }
        public long MarkId { get; set; }
        public string Name { get; set; }

        public virtual CounterMark Mark { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
        public virtual ICollection<HouseCounter2> HouseCounter2s { get; set; }
    }
}
