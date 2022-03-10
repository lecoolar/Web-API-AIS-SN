using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceCountersView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long? AccountId { get; set; }
        public long? ServiceId { get; set; }
        public int? ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceTypeName { get; set; }
        public int? OrgCode { get; set; }
        public string OrgName { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? CounterSize { get; set; }
        public decimal? CounterFactor { get; set; }
        public int? CounterTypeId { get; set; }
        public string CounterTypeName { get; set; }
        public int? MaddleTypeId { get; set; }
        public string MaddleTypeName { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public DateTime CounterCreated { get; set; }
        public decimal? Share { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
        public decimal? FactorConsumption { get; set; }
    }
}
