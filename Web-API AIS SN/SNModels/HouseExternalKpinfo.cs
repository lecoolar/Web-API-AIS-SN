using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseExternalKpinfo
    {
        public string ObjectId { get; set; }
        public string SnhouseAdrid { get; set; }
        public string Year { get; set; }
        public string ComposedFullName { get; set; }
        public string ElementName { get; set; }
        public string UnitName { get; set; }
        public string ElementAmount { get; set; }
        public string CostPerUnit { get; set; }
        public string RepairCost { get; set; }
        public string Raised { get; set; }
        public string Percent { get; set; }
    }
}
