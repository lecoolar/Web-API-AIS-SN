using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseGeneralContractorsView
    {
        public long Id { get; set; }
        public long GeneralContractorId { get; set; }
        public int GeneralContractorCode { get; set; }
        public string GeneralContractorName { get; set; }
        public long HouseId { get; set; }
        public long AddrId { get; set; }
        public string AddrName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
    }
}
