using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseServiceNormTypesWithNormView
    {
        public long? Id { get; set; }
        public long HouseId { get; set; }
        public long ServiceTypeId { get; set; }
        public long? HouseServiceNormId { get; set; }
        public long? HouseServiceNormTypeId { get; set; }
        public int NormTypeId { get; set; }
        public string NormTypeName { get; set; }
        public decimal? Rate { get; set; }
    }
}
