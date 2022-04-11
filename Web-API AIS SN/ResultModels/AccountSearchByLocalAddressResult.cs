using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountSearchByLocalAddressResult
    {
        public string AccountNumber { get; set; }
        public string FullAddress { get; set; }
        public string Owner { get; set; }
        public string FiasHouse { get; set; }
        public string FiasRoom { get; set; }
        public string Room { get; set; }
        public string House { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public bool? IsClose { get; set; }
        public long? ApartmentId { get; set; }
        public string TerritorialSubDivisionName { get; set; }
        public string TerritorialSubDivisionCode { get; set; }
        public bool? AnyCounters { get; set; }
        public bool? IndicationAVG { get; set; }

    }
}
