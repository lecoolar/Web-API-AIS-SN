using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAction
    {
        public DebtAction()
        {
            BankPaymentOrdersRecords = new HashSet<BankPaymentOrdersRecord>();
            DebtAccountAttachCharges = new HashSet<DebtAccountAttachCharge>();
            DebtAccountAttachPayments = new HashSet<DebtAccountAttachPayment>();
            DebtActionEvents = new HashSet<DebtActionEvent>();
            DebtActionNotices = new HashSet<DebtActionNotice>();
            DebtAffairOwners = new HashSet<DebtAffairOwner>();
            GroupOperations = new HashSet<GroupOperation>();
            Request1s = new HashSet<Request1>();
        }

        public long Id { get; set; }
        public long DebtAffairId { get; set; }
        public long DebtAccountId { get; set; }
        public int StatusId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public string NameAction { get; set; }
        public string ExecProcessNumber { get; set; }
        public string CourtProcessNumber { get; set; }
        public long? StageId { get; set; }
        public string DebtActionNumber { get; set; }
        public int? TypePir { get; set; }
        public int? TypeStageResult { get; set; }
        public string DebtAffairNumber { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public long? CreatedUserId { get; set; }
        public long? ChangedUserId { get; set; }
        public DateTime? DateChange { get; set; }

        public virtual DebtAccount DebtAccount { get; set; }
        public virtual DebtAffair DebtAffair { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual FasetItem TypePirNavigation { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecords { get; set; }
        public virtual ICollection<DebtAccountAttachCharge> DebtAccountAttachCharges { get; set; }
        public virtual ICollection<DebtAccountAttachPayment> DebtAccountAttachPayments { get; set; }
        public virtual ICollection<DebtActionEvent> DebtActionEvents { get; set; }
        public virtual ICollection<DebtActionNotice> DebtActionNotices { get; set; }
        public virtual ICollection<DebtAffairOwner> DebtAffairOwners { get; set; }
        public virtual ICollection<GroupOperation> GroupOperations { get; set; }
        public virtual ICollection<Request1> Request1s { get; set; }
    }
}
