using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestStreamFile
    {
        public long Id { get; set; }
        public long MpaRequestId { get; set; }
        public long StreamFilesId { get; set; }
    }
}
