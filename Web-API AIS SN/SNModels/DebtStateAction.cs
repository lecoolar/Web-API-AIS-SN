using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtStateAction
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ActionId { get; set; }
        public int DebtListNoticeId { get; set; }
        public DateTime? Created { get; set; }
        public int? TypePeriodMonitorId { get; set; }
        public int? TypePir { get; set; }
    }
}
