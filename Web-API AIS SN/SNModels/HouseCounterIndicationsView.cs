using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounterIndicationsView
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public decimal Val { get; set; }
        public decimal? ValDop { get; set; }
        public decimal? ValRevert { get; set; }
        public int ValType { get; set; }
        public string ValTypeName { get; set; }
        public DateTime ValDate { get; set; }
        public DateTime Created { get; set; }
        public decimal TariffSquare { get; set; }
        public decimal HouseSquare { get; set; }
        public decimal? HouseConsumptionVolume { get; set; }
        public decimal? ApatrmentCountersVolume { get; set; }
        public decimal? ApatrmentNormativesVolume { get; set; }
        public decimal ValInfo { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public bool? IsUseNegativeValue { get; set; }
        public decimal? LimitFactor { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string Note { get; set; }
        public long? GroupOperId { get; set; }
        public decimal? Consumption { get; set; }
        public decimal? ApartmentCounterAdditionalVolume { get; set; }
        public decimal? ApartmentNormativeAdditionalVolume { get; set; }
        public long? OrgDocId { get; set; }
    }
}
