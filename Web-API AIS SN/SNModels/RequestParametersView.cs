using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestParametersView
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long RequestId { get; set; }
        public long? LocalAddressId { get; set; }
        public long? ServiceOldId { get; set; }
        public DateTime? ServiceOldDateClose { get; set; }
        public long? ServiceNewId { get; set; }
        public DateTime? ServiceNewDateOpen { get; set; }
        public string LocalAddressName { get; set; }
        public string ServiceOldName { get; set; }
        public string ServiceNewName { get; set; }
    }
}
