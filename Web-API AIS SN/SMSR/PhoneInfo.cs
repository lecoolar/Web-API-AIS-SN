using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PhoneInfo
    {
        public long Id { get; set; }
        public long PhoneId { get; set; }
        public bool? Send { get; set; }
        public int? CountShowSend { get; set; }
        public int? CountShowMeassage { get; set; }
        public string Device { get; set; }
        public string Token { get; set; }
        public DateTime? DateChangeLogin { get; set; }
        public Guid? GuidInShop { get; set; }

        public virtual Phone Phone { get; set; }
    }
}
