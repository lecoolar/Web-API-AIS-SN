using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentTkoplatformsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public string Description { get; set; }
        public int CallsCount { get; set; }
        public int PeriodicityId { get; set; }
        public string PeriodicityName { get; set; }
        public long? LocalityId { get; set; }
        public string LocalityName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool? IsTko { get; set; }
        public string TkoType { get; set; }
    }
}
