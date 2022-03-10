using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class WorkTimeTemplate
    {
        public WorkTimeTemplate()
        {
            ApartmentWorkTimes = new HashSet<ApartmentWorkTime>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal? Monday { get; set; }
        public decimal? Tuesday { get; set; }
        public decimal? Wednesday { get; set; }
        public decimal? Thursday { get; set; }
        public decimal? Friday { get; set; }
        public decimal? Saturday { get; set; }
        public decimal? Sunday { get; set; }
        public bool? DefaultTemplate { get; set; }

        public virtual ICollection<ApartmentWorkTime> ApartmentWorkTimes { get; set; }
    }
}
