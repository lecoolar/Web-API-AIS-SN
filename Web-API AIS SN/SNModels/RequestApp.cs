using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestApp
    {
        public long Id { get; set; }
        public long RequestId { get; set; }
        public string AppData { get; set; }

        public virtual Request Request { get; set; }
    }
}
