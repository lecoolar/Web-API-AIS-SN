using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestParameter
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long RequestId { get; set; }
        public long? LocalAddressId { get; set; }
        public long? ServiceOldId { get; set; }
        public DateTime? ServiceOldDateClose { get; set; }
        public long? ServiceNewId { get; set; }
        public DateTime? ServiceNewDateOpen { get; set; }
    }
}
