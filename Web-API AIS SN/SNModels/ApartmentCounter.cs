using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounter
    {
        public ApartmentCounter()
        {
            AccountServiceCounter1s = new HashSet<AccountServiceCounter1>();
            ApartmentCounterBetweenCheckIntervals = new HashSet<ApartmentCounterBetweenCheckInterval>();
            ApartmentCounterCheckIntervals = new HashSet<ApartmentCounterCheckInterval>();
            ApartmentCounterIndication1s = new HashSet<ApartmentCounterIndication1>();
            ApartmentCounterLinkages = new HashSet<ApartmentCounterLinkage>();
            ApartmentCounterPlaces = new HashSet<ApartmentCounterPlace>();
            ApartmentCounterSeals = new HashSet<ApartmentCounterSeal>();
            ApartmentCounterShares = new HashSet<ApartmentCounterShare>();
            ApartmentCounterVolumes = new HashSet<ApartmentCounterVolume>();
            ApartmentEquipmentCounters = new HashSet<ApartmentEquipmentCounter>();
            InverseOldCounter = new HashSet<ApartmentCounter>();
            RequestCounters = new HashSet<RequestCounter>();
        }

        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int? TypeId { get; set; }
        public string CounterName { get; set; }
        public string CounterNumber { get; set; }
        public int? CounterSize { get; set; }
        public decimal? Factor { get; set; }
        public int? MaddleType { get; set; }
        public string Stamp { get; set; }
        public DateTime? StampDate { get; set; }
        public long? MarkId { get; set; }
        public int? PlaceId { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public int? TypeScaleCounterId { get; set; }
        public string PointAccounting { get; set; }
        public decimal? Power { get; set; }
        public long? CounterServiceTypeId { get; set; }
        public long? SessionId { get; set; }
        public long? UserId { get; set; }
        public byte? Act { get; set; }
        public int? StatusAskupe { get; set; }
        public int? CommunalShareTypeId { get; set; }
        public byte? ReesterOrderNumber { get; set; }
        public int? CloseReasonId { get; set; }
        public string CounterCodeProvider { get; set; }
        public DateTime? CounterRelease { get; set; }
        public int? UnitMeasureId { get; set; }
        public int? Fraction { get; set; }
        public long? ModelId { get; set; }
        public bool? IsRemotelyRemoteIndications { get; set; }
        public DateTime? DateSealing { get; set; }
        public string InfoSensorTemperature { get; set; }
        public string InfoSensorPressure { get; set; }
        public string ExternalCode { get; set; }
        public long? OldCounterId { get; set; }
        public DateTime? LiquidationRefDate { get; set; }
        public string Comment { get; set; }
        public string CounterNumberAismeter { get; set; }
        public string CounterSmallName { get; set; }
        public int? CounterSmallNameId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
        public virtual FasetItem CommunalShareType { get; set; }
        public virtual ServiceType CounterServiceType { get; set; }
        public virtual FasetItem MaddleTypeNavigation { get; set; }
        public virtual CounterMark Mark { get; set; }
        public virtual CounterModel Model { get; set; }
        public virtual ApartmentCounter OldCounter { get; set; }
        public virtual FasetItem Place { get; set; }
        public virtual Session Session { get; set; }
        public virtual FasetItem StatusAskupeNavigation { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual FasetItem TypeScaleCounter { get; set; }
        public virtual User User { get; set; }
        public virtual ApartmentCounterName ApartmentCounterName { get; set; }
        public virtual ICollection<AccountServiceCounter1> AccountServiceCounter1s { get; set; }
        public virtual ICollection<ApartmentCounterBetweenCheckInterval> ApartmentCounterBetweenCheckIntervals { get; set; }
        public virtual ICollection<ApartmentCounterCheckInterval> ApartmentCounterCheckIntervals { get; set; }
        public virtual ICollection<ApartmentCounterIndication1> ApartmentCounterIndication1s { get; set; }
        public virtual ICollection<ApartmentCounterLinkage> ApartmentCounterLinkages { get; set; }
        public virtual ICollection<ApartmentCounterPlace> ApartmentCounterPlaces { get; set; }
        public virtual ICollection<ApartmentCounterSeal> ApartmentCounterSeals { get; set; }
        public virtual ICollection<ApartmentCounterShare> ApartmentCounterShares { get; set; }
        public virtual ICollection<ApartmentCounterVolume> ApartmentCounterVolumes { get; set; }
        public virtual ICollection<ApartmentEquipmentCounter> ApartmentEquipmentCounters { get; set; }
        public virtual ICollection<ApartmentCounter> InverseOldCounter { get; set; }
        public virtual ICollection<RequestCounter> RequestCounters { get; set; }
    }
}
