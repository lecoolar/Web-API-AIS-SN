using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtDocument
    {
        public DebtDocument()
        {
            DebtAccounts = new HashSet<DebtAccount>();
        }

        public long Id { get; set; }
        public long? OrgDocId { get; set; }
        public long? HouseHolderId { get; set; }
        public decimal? DebtSumm { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public bool? ShowInterface { get; set; }
        public DateTime? PaymentToDate { get; set; }
        public decimal? TaxSumm { get; set; }
        public bool? ManuallyCreated { get; set; }
        public DateTime? PenaltyToDate { get; set; }
        public bool? WithoutNegativeDebt { get; set; }
        public bool? WithExcludeProcesses { get; set; }
        public long? UserId { get; set; }
        public int? DebtMode { get; set; }
        public int? PenyMode { get; set; }
        public int? DebtSaveMode { get; set; }
        public bool? CalculatePenalties { get; set; }
        public bool? IsOnlyOpenAccounts { get; set; }
        public bool? IsOnlyOpenAccountServices { get; set; }
        public DateTime? DebtFromDate { get; set; }
        public DateTime? DebtToDate { get; set; }
        public bool? CalculateGosposhlina { get; set; }
        public bool? WithApOwners { get; set; }

        public virtual Organization1 HouseHolder { get; set; }
        public virtual OrgDocument OrgDoc { get; set; }
        public virtual ICollection<DebtAccount> DebtAccounts { get; set; }
    }
}
