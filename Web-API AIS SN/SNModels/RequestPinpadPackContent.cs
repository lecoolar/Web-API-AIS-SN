using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestPinpadPackContent
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long RequestId { get; set; }
        public long RequestPinpadPackId { get; set; }

        public virtual Request1 Request { get; set; }
        public virtual RequestPinpadPack RequestPinpadPack { get; set; }
    }
}
