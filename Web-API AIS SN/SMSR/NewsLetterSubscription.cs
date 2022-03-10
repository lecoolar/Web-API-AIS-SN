using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class NewsLetterSubscription
    {
        public int Id { get; set; }
        public Guid NewsLetterSubscriptionGuid { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public int StoreId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}
