using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestPinpadPack
    {
        public RequestPinpadPack()
        {
            RequestPinpadPackContents = new HashSet<RequestPinpadPackContent>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public long? PinpadCode { get; set; }
        public string PinpadData { get; set; }

        public virtual ICollection<RequestPinpadPackContent> RequestPinpadPackContents { get; set; }
    }
}
