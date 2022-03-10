using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RolesView
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string TypeRole { get; set; }
        public string PrintName { get; set; }
    }
}
