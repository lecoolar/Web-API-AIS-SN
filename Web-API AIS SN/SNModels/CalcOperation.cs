using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcOperation
    {
        public CalcOperation()
        {
            CalcOperationGroupContents = new HashSet<CalcOperationGroupContent>();
            Jn1s = new HashSet<Jn1>();
            PayJns = new HashSet<PayJn>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }
        public short? Opsign { get; set; }
        public int? OffBalance { get; set; }
        public decimal? Ko { get; set; }
        public string Split { get; set; }
        public bool AllowManuallyAdding { get; set; }
        public bool AllowEditingInCurrentPeriod { get; set; }
        public bool AllowEditingInAnyPeriod { get; set; }
        public int? OffBalanceBenefit { get; set; }

        public virtual ICollection<CalcOperationGroupContent> CalcOperationGroupContents { get; set; }
        public virtual ICollection<Jn1> Jn1s { get; set; }
        public virtual ICollection<PayJn> PayJns { get; set; }
    }
}
