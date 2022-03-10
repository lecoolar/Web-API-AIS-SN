using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTypeGroupPermit
    {
        public long Id { get; set; }
        public int GroupTypeId { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }

        public virtual FasetItem GroupType { get; set; }
    }
}
