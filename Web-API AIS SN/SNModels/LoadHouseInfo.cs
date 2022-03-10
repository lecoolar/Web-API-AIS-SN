using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadHouseInfo
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatusId { get; set; }
        public long? BillId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string PostalIndex { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int? ServiceCode { get; set; }
        public int? OrgCode { get; set; }
        public string CounterNumb { get; set; }
        public string Volime { get; set; }
        public string ConsOdnktu { get; set; }
        public string PrevValOdpu { get; set; }
        public string ValOdpu { get; set; }
        public string NormOne { get; set; }
        public string AreaOdn { get; set; }
        public string MaxLimChargePay { get; set; }
        public string CounterDateb { get; set; }
        public string CounterMark { get; set; }
        public string DateInstCounter { get; set; }
        public string FiasHouse { get; set; }
        public string FiasParent { get; set; }
        public string CounterType { get; set; }
        public string DateLastControl { get; set; }
        public string IsRemoteControl { get; set; }
        public string NameSystemRemote { get; set; }
        public string IsHateSign { get; set; }
        public string IsPressureSign { get; set; }
        public long? LocalDistrictId { get; set; }
        public long? CityId { get; set; }
        public long? StreetId { get; set; }
        public long? HouseId { get; set; }
        public long? FlatId { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public long? ExtRecordId { get; set; }
        public string AllConsumptionOdpu { get; set; }
        public string AllConsumptionLiving { get; set; }
        public string AllConsumptionNotLiving { get; set; }
        public string ConsumptionOdnMkd { get; set; }
        public string ConsumptionOdnNorm { get; set; }
        public string MeterType { get; set; }
        public string Unit { get; set; }
    }
}
