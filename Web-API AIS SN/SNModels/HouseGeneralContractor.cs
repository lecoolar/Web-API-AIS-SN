using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseGeneralContractor
    {
        public long Id { get; set; }
        public long GeneralContractorId { get; set; }
        public long HouseId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }

        public virtual Organization1 GeneralContractor { get; set; }
        public virtual House House { get; set; }
    }
}
