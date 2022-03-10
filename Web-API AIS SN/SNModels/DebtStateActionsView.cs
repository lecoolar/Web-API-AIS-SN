using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtStateActionsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ActionId { get; set; }
        public string ActionName { get; set; }
        public int DebtListNoticeId { get; set; }
        public string DebtListNoticeName { get; set; }
        public DateTime? Created { get; set; }
        public int? TypePeriodMonitorId { get; set; }
        public string TypePeriodMonitorName { get; set; }
        public int? TypePir { get; set; }
        public string TypePirname { get; set; }
    }
}
