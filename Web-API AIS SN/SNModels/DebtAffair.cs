using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAffair
    {
        public DebtAffair()
        {
            DebtActions = new HashSet<DebtAction>();
            DebtAffairOwners = new HashSet<DebtAffairOwner>();
        }

        public long Id { get; set; }
        public string Comment { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? CategoryId { get; set; }
        public string ScanPath { get; set; }
        public string DebtAffairNumber { get; set; }
        public long? AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual FasetItem Category { get; set; }
        public virtual ICollection<DebtAction> DebtActions { get; set; }
        public virtual ICollection<DebtAffairOwner> DebtAffairOwners { get; set; }
    }
}
