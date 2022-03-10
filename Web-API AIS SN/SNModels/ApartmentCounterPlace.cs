using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterPlace
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public DateTime FromDate { get; set; }
        public int FasetItemId { get; set; }

        public virtual ApartmentCounter Counter { get; set; }
        public virtual FasetItem FasetItem { get; set; }
    }
}
