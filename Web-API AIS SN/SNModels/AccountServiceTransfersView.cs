using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTransfersView
    {
        public long Id { get; set; }
        public long? AccountServiceId { get; set; }
        public long? AccountServiceNewId { get; set; }
        public int AccountServiceNewServiceCode { get; set; }
        public string AccountServiceNewServiceName { get; set; }
        public int? AccountServiceNewHouseHolderCode { get; set; }
        public string AccountServiceNewHouseHolderName { get; set; }
        public int? AccountServiceNewProviderCode { get; set; }
        public string AccountServiceNewProviderName { get; set; }
        public long? GroupOperId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
