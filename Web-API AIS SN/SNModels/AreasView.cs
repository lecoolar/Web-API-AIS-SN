using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AreasView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int StatusTemporary { get; set; }
        public bool IsSystem { get; set; }
        public long? AreaGroupId { get; set; }
        public string AreaGroupName { get; set; }
    }
}
