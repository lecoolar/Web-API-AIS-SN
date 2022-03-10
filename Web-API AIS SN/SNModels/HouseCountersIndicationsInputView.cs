using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCountersIndicationsInputView
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public long CounterId { get; set; }
        public string CounterName { get; set; }
        public string TypeCounterName { get; set; }
        public string CounterNumber { get; set; }
        public string PointAccounting { get; set; }
        public decimal Val { get; set; }
        public DateTime ValDate { get; set; }
        public string ValTypeName { get; set; }
        public string ServiceTypeName { get; set; }
        public int? ValType { get; set; }
        public int? TypeId { get; set; }
        public decimal? ValDop { get; set; }
        public decimal? ApartmentCounterAdditionalVolume { get; set; }
        public decimal? ApartmentNormativeAdditionalVolume { get; set; }
        public DateTime CounterFromDate { get; set; }
        public DateTime? CounterToDate { get; set; }
        public DateTime Created { get; set; }
        public int? NewValTypeId { get; set; }
        public string NewValType { get; set; }
        public DateTime NewValDate { get; set; }
        public long? ServiceTypeId { get; set; }
        public string ServiceTypeAlias { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public decimal? Consumption { get; set; }
        public bool? IsSaveDuplicateIndication { get; set; }
        public long? UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Note { get; set; }
    }
}
