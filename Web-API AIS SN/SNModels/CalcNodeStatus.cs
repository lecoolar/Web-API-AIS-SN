using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcNodeStatus
    {
        public CalcNodeStatus()
        {
            CalcNodes = new HashSet<CalcNode>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CalcNode> CalcNodes { get; set; }
    }
}
