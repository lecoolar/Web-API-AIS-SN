using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class TempPhonesSv1208
    {
        public long Id { get; set; }
        public string Value { get; set; }
        public string Pass { get; set; }
        public string Owner { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string PersonInn { get; set; }
        public string PersonSnils { get; set; }
        public string ContactPhone { get; set; }
        public Guid? GenerateToken { get; set; }
        public bool? EmailConfirmed { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateConfirmation { get; set; }
        public Guid? GenerateTokenForEmail { get; set; }
        public int? CountShowMeassage { get; set; }
        public DateTime? LastloginDate { get; set; }
        public long? InfoId { get; set; }
        public bool? AcceptingPolicy { get; set; }
    }
}
