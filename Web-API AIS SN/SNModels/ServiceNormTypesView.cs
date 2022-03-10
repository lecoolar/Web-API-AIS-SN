using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceNormTypesView
    {
        public long Id { get; set; }
        public long? ServiceNormId { get; set; }
        public decimal? Rate { get; set; }
        public short FasetId { get; set; }
        public string FasetName { get; set; }
        public int? ApartmentPropertyId { get; set; }
        public string ApartmentPropertyName { get; set; }
    }
}
