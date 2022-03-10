using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreaGroup
    {
        public AreaGroup()
        {
            Areas = new HashSet<Area>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
    }
}
