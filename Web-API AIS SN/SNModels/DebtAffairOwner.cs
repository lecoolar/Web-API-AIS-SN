using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAffairOwner
    {
        public long Id { get; set; }
        public long? DebtAffairId { get; set; }
        public long? OwnerId { get; set; }
        public string DebtAffairOwnerName { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsJustResident { get; set; }
        public long? PersonResidentId { get; set; }
        public string TelephoneNumber { get; set; }
        public string PlaceEmployment { get; set; }
        public string Comment { get; set; }
        public long? DebtActionId { get; set; }

        public virtual DebtAction DebtAction { get; set; }
        public virtual DebtAffair DebtAffair { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Person PersonResident { get; set; }
    }
}
