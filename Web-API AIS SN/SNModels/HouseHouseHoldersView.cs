using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseHouseHoldersView
    {
        public long Id { get; set; }
        public long HouseHolderId { get; set; }
        public string HouseHolderName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public int HouseHolderCode { get; set; }
        public long HouseId { get; set; }
        public long AddrId { get; set; }
        public string FiasCode { get; set; }
        public string AddrName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public bool IsServiceProvider { get; set; }
        public bool IsHouseHolder { get; set; }
    }
}
