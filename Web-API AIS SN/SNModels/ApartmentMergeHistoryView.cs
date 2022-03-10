using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentMergeHistoryView
    {
        public long Id { get; set; }
        public long PreviousApartmentId { get; set; }
        public string PreviousNumber { get; set; }
        public string PreviousAddressName { get; set; }
        public string PreviousOwnerName { get; set; }
        public DateTime? PreviousFromDate { get; set; }
        public DateTime? PreviousToDate { get; set; }
        public long NextApartmentId { get; set; }
        public string NextNumber { get; set; }
        public string NextAddressName { get; set; }
        public string NextOwnerName { get; set; }
        public DateTime? NextFromDate { get; set; }
        public DateTime? NextToDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
    }
}
