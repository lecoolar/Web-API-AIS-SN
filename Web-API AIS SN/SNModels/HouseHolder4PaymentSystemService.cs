using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseHolder4PaymentSystemService
    {
        public long Id { get; set; }
        public string HouseHolderCode { get; set; }
        public string ProviderCode { get; set; }
        public string PaymentSystemServiceCode { get; set; }
        public string TypeName { get; set; }
        public string PaymentAgent { get; set; }
        public string PaymentSystem { get; set; }
        public string ServiceHouseHolderCode { get; set; }
    }
}
