using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtNotificationsRenderedView
    {
        public long Id { get; set; }
        public DateTime? Period { get; set; }
        public long AccountId { get; set; }
        public string Number { get; set; }
        public decimal DebtSumm { get; set; }
        public DateTime Created { get; set; }
    }
}
