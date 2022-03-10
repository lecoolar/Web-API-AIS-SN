using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class Request
    {
        public long Id { get; set; }
        public long PhoneId { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }
        public string ExternalNumber { get; set; }
        public int Status { get; set; }
        public long? AppealTypesId { get; set; }
    }
}
