using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Session
    {
        public Session()
        {
            ApartmentCounterCheckIntervals = new HashSet<ApartmentCounterCheckInterval>();
            ApartmentCounterIndication1s = new HashSet<ApartmentCounterIndication1>();
            ApartmentCounterSeals = new HashSet<ApartmentCounterSeal>();
            ApartmentCounterVolumes = new HashSet<ApartmentCounterVolume>();
            ApartmentCounters = new HashSet<ApartmentCounter>();
        }

        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Ip { get; set; }
        public string Host { get; set; }
        public long UserId { get; set; }
        public string ArmName { get; set; }
        public long Spid { get; set; }
        public Guid ConnectionId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ApartmentCounterCheckInterval> ApartmentCounterCheckIntervals { get; set; }
        public virtual ICollection<ApartmentCounterIndication1> ApartmentCounterIndication1s { get; set; }
        public virtual ICollection<ApartmentCounterSeal> ApartmentCounterSeals { get; set; }
        public virtual ICollection<ApartmentCounterVolume> ApartmentCounterVolumes { get; set; }
        public virtual ICollection<ApartmentCounter> ApartmentCounters { get; set; }
    }
}
