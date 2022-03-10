using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCharacteristic
    {
        public int Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime? FromDate { get; set; }
        public string BoilerRoom { get; set; }
        public decimal BuldingVolume { get; set; }
        public decimal SpecificHeatingCharacteristic { get; set; }
        public decimal MaxDesignLoad { get; set; }
        public decimal? DailyConsumption { get; set; }
        public decimal? NumberConsumersByNorm { get; set; }
        public long? ServiceTypeId { get; set; }
        public bool? CounterAvailability { get; set; }
        public decimal? WaterConsumption { get; set; }
        public bool? IsUseTemperatureCoef { get; set; }

        public virtual Apartment1 Apartment { get; set; }
    }
}
