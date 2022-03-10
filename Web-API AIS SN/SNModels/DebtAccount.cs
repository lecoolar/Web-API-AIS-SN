using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccount
    {
        public DebtAccount()
        {
            DebtAccountAttachPayments = new HashSet<DebtAccountAttachPayment>();
            DebtAccountServices = new HashSet<DebtAccountService>();
            DebtActions = new HashSet<DebtAction>();
            DebtRecoveredAmounts = new HashSet<DebtRecoveredAmount>();
        }

        public long Id { get; set; }
        public long DebtDocumentId { get; set; }
        public long AccountId { get; set; }
        public decimal? DebtSumm { get; set; }
        public int? MonthCount { get; set; }
        public int? TypeIdAnomaly { get; set; }
        public DateTime? DateAnomaly { get; set; }
        public int? TypeStatusByNotice { get; set; }
        public string Comment { get; set; }
        public long? ScanDocId { get; set; }
        public long? UserId { get; set; }
        public string DebtAccountNumber { get; set; }
        public decimal? Gosposhlina { get; set; }
        public decimal? Peny { get; set; }
        public DateTime? DebtFromDate { get; set; }
        public DateTime? DebtToDate { get; set; }
        public decimal? RepresentationExpenses { get; set; }
        public long? ApartmentOwnerId { get; set; }
        public int? DebtRank { get; set; }

        public virtual Account Account { get; set; }
        public virtual DebtDocument DebtDocument { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<DebtAccountAttachPayment> DebtAccountAttachPayments { get; set; }
        public virtual ICollection<DebtAccountService> DebtAccountServices { get; set; }
        public virtual ICollection<DebtAction> DebtActions { get; set; }
        public virtual ICollection<DebtRecoveredAmount> DebtRecoveredAmounts { get; set; }
    }
}
