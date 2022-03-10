using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExchangeRequestGroup
    {
        public long Id { get; set; }
        public int? GroupId { get; set; }
        public long? ConnectPsId { get; set; }

        public virtual Setting ConnectPs { get; set; }
    }
}
