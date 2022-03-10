using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T80213ApartmentRequestAccount
    {
        public long Id { get; set; }
        public long ApartmentRequestId { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }
    }
}
