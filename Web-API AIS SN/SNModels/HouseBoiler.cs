using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseBoiler
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long BoilerId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Created { get; set; }

        public virtual Boiler Boiler { get; set; }
        public virtual House House { get; set; }
    }
}
