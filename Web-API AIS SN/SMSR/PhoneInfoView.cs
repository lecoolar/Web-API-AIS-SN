using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PhoneInfoView
    {
        public long Id { get; set; }
        public string Value { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Owner { get; set; }
        public string ContactPhone { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateConfirmation { get; set; }
        public Guid? GenerateTokenForEmail { get; set; }
        public DateTime? DateChangeLogin { get; set; }
        public Guid? GuidInShop { get; set; }
        public bool? Send { get; set; }
        public string Token { get; set; }
        public string Device { get; set; }
    }
}
