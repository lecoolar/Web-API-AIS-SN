using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseIndicationsFile
    {
        public long Id { get; set; }
        public long CounterIndicationId { get; set; }
        public long StreamFilesId { get; set; }

        public virtual HouseCounterIndication CounterIndication { get; set; }
        public virtual StreamFile StreamFiles { get; set; }
    }
}
