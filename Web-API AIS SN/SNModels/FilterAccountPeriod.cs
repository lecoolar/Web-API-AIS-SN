using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FilterAccountPeriod
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Period { get; set; }
        public long? UserId { get; set; }
        public DateTime ConfirmDate { get; set; }
    }
}
