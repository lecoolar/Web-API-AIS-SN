using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcOperationGroup
    {
        public CalcOperationGroup()
        {
            CalcOperationGroupContents = new HashSet<CalcOperationGroupContent>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsInverted { get; set; }

        public virtual ICollection<CalcOperationGroupContent> CalcOperationGroupContents { get; set; }
    }
}
