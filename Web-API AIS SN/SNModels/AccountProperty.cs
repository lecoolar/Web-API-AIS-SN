using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountProperty
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public int PropertyId { get; set; }
        public bool PropertyValue { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }
        public string NumberPd { get; set; }
        public long? UserId { get; set; }

        public virtual Account Account { get; set; }
        public virtual FasetItem Property { get; set; }
        public virtual User User { get; set; }
    }
}
