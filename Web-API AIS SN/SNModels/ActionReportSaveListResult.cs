using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionReportSaveListResult
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public long AccountId { get; set; }
        public DateTime CalcPeriod { get; set; }
        public decimal ConsService { get; set; }
        public decimal ConsServiceOdn { get; set; }
        public decimal SizePayServiceCons { get; set; }
        public decimal SizePayServiceConsOdn { get; set; }
        public decimal Benefit { get; set; }
        public decimal ChargeItogPeriod { get; set; }
        public decimal ChargeItogPeriodOdn { get; set; }
        public decimal SaldoBegin { get; set; }
        public decimal PenyCurrPeriod { get; set; }
        public decimal PayCurrPeriod { get; set; }
        public decimal SaldoEnd { get; set; }
        public long ProcessingId { get; set; }
        public long BillId { get; set; }
        public long SubDivId { get; set; }
        public long? LocalDistrictId { get; set; }
        public long CityId { get; set; }
        public long StreetId { get; set; }
        public long HouseId { get; set; }
        public long FlatId { get; set; }
        public long ApartmentId { get; set; }
        public long? Ownerid { get; set; }
        public long StatusId { get; set; }
        public string FiasCode { get; set; }
    }
}
