using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTransfer
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public long? AccountServiceNewId { get; set; }
        public long? GroupOperId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual AccountService4 AccountServiceNew { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
    }
}
