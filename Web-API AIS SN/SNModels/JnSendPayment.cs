using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class JnSendPayment
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long? AgentId { get; set; }
        public decimal? Summ { get; set; }
        public decimal? Comm { get; set; }
        public long? AccountId { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public long GroupOperId { get; set; }
        public string ProviderUno { get; set; }
        public DateTime? ProviderData { get; set; }
    }
}
