using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CountersView
    {
        public string Code { get; set; }
        public string Number { get; set; }
        public string SlavedNumber { get; set; }
        public string Model { get; set; }
        public long? AdrId { get; set; }
        public string EnergyResource { get; set; }
        public string EnergyResourceName { get; set; }
        public int? Scale { get; set; }
        public int? CountScale { get; set; }
        public decimal? LastVal { get; set; }
        public DateTime? LastValDate { get; set; }
        public decimal? Koefficient { get; set; }
        public DateTime? DateVerification { get; set; }
        public DateTime? ToDate { get; set; }
        public string Prefix { get; set; }
        public int? Capacity { get; set; }
        public string AddrObjectCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public long? ResourceCounterGroup { get; set; }
        public long? HouseId { get; set; }
        public int IsHouseCounter { get; set; }
        public string Comment { get; set; }
        public DateTime? LoadDate { get; set; }
        public DateTime? LastLoadActiveDate { get; set; }
        public string LastLoadActiveFile { get; set; }
    }
}
