using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseCounter2
    {
        public HouseCounter2()
        {
            HouseCounterApartments = new HashSet<HouseCounterApartment>();
            HouseCounterAreas = new HashSet<HouseCounterArea>();
            HouseCounterBetweenCheckIntervals = new HashSet<HouseCounterBetweenCheckInterval>();
            HouseCounterDelta = new HashSet<HouseCounterDeltum>();
            HouseCounterHierarchyHouseCounters = new HashSet<HouseCounterHierarchy>();
            HouseCounterHierarchyParentHouseCounters = new HashSet<HouseCounterHierarchy>();
            HouseCounterIndications = new HashSet<HouseCounterIndication>();
            HouseCounterNonresidentialApartmentConsumptions = new HashSet<HouseCounterNonresidentialApartmentConsumption>();
            HouseCounterServiceCounters = new HashSet<HouseCounterServiceCounter>();
            HouseCounterServiceNorms = new HashSet<HouseCounterServiceNorm>();
            HouseCounterServices = new HashSet<HouseCounterService>();
            HouseCounters = new HashSet<HouseCounter>();
            NonresidentialApartmentHouseCounters = new HashSet<NonresidentialApartmentHouseCounter>();
        }

        public long Id { get; set; }
        public long HouseId { get; set; }
        public int? TypeCounterId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? Capacity { get; set; }
        public long? MarkId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public long? ServiceTypeId { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public decimal? Factor { get; set; }
        public bool? IsInternal { get; set; }
        public string Note { get; set; }
        public string PointAccounting { get; set; }
        public int? StatusAskupe { get; set; }
        public bool IsAvailableAvgConsumption { get; set; }
        public int? MeasureUnitsId { get; set; }
        public long? ModelId { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
        public DateTime? DateSealing { get; set; }
        public string InfoSensorTemperature { get; set; }
        public string InfoSensorPressure { get; set; }
        public string ExternalCode { get; set; }
        public DateTime? LiquidationRefDate { get; set; }
        public string Comment { get; set; }
        public bool? IsNotUnloadGis { get; set; }
        public bool? IsOwnedRso { get; set; }
        public long? OldCounterId { get; set; }

        public virtual House House { get; set; }
        public virtual CounterModel Model { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual FasetItem StatusAskupeNavigation { get; set; }
        public virtual FasetItem TypeCounter { get; set; }
        public virtual ICollection<HouseCounterApartment> HouseCounterApartments { get; set; }
        public virtual ICollection<HouseCounterArea> HouseCounterAreas { get; set; }
        public virtual ICollection<HouseCounterBetweenCheckInterval> HouseCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<HouseCounterDeltum> HouseCounterDelta { get; set; }
        public virtual ICollection<HouseCounterHierarchy> HouseCounterHierarchyHouseCounters { get; set; }
        public virtual ICollection<HouseCounterHierarchy> HouseCounterHierarchyParentHouseCounters { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndications { get; set; }
        public virtual ICollection<HouseCounterNonresidentialApartmentConsumption> HouseCounterNonresidentialApartmentConsumptions { get; set; }
        public virtual ICollection<HouseCounterServiceCounter> HouseCounterServiceCounters { get; set; }
        public virtual ICollection<HouseCounterServiceNorm> HouseCounterServiceNorms { get; set; }
        public virtual ICollection<HouseCounterService> HouseCounterServices { get; set; }
        public virtual ICollection<HouseCounter> HouseCounters { get; set; }
        public virtual ICollection<NonresidentialApartmentHouseCounter> NonresidentialApartmentHouseCounters { get; set; }
    }
}
