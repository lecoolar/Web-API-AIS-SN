using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountInfoMessage
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public string Message { get; set; }

        public virtual Account Account { get; set; }
    }
}
