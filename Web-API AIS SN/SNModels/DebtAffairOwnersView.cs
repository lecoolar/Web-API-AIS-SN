using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAffairOwnersView
    {
        public long Id { get; set; }
        public long DebtAffairId { get; set; }
        public long? OwnerId { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsJustResident { get; set; }
        public string DebtAffairOwnerName { get; set; }
        public long? PersonResidentId { get; set; }
        public string TelephoneNumber { get; set; }
        public string PlaceEmployment { get; set; }
        public string Comment { get; set; }
        public string OwnerName { get; set; }
        public long? OwnerPersonId { get; set; }
        public string PrintCurrentStatus { get; set; }
        public string ResidentAddress { get; set; }
        public string DocNumber { get; set; }
        public long? DebtActionId { get; set; }
        public string AffairOwnerType { get; set; }
    }
}
