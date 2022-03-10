using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupOperation
    {
        public GroupOperation()
        {
            AccountServicePenaltyRemissions = new HashSet<AccountServicePenaltyRemission>();
            AccountServiceSubQualities = new HashSet<AccountServiceSubQuality>();
            AccountServiceSuspensions = new HashSet<AccountServiceSuspension>();
            AccountServiceTransfers = new HashSet<AccountServiceTransfer>();
            ApartmentCounterIndication1s = new HashSet<ApartmentCounterIndication1>();
            ApartmentCounterVolumes = new HashSet<ApartmentCounterVolume>();
            BankPaymentOrdersRecords = new HashSet<BankPaymentOrdersRecord>();
            DebtAccountAttachPayments = new HashSet<DebtAccountAttachPayment>();
            GroupOperCalcCounterParams = new HashSet<GroupOperCalcCounterParam>();
            GroupOperCalcHouseCounterParam1s = new HashSet<GroupOperCalcHouseCounterParam1>();
            GroupOperCalcHouseCounterParams = new HashSet<GroupOperCalcHouseCounterParam>();
            GroupOperCalcParam1s = new HashSet<GroupOperCalcParam1>();
            GroupOperationSequenceChildren = new HashSet<GroupOperationSequence>();
            GroupOperationSequenceParents = new HashSet<GroupOperationSequence>();
            HouseCounterDelta = new HashSet<HouseCounterDeltum>();
            HouseCounterIndications = new HashSet<HouseCounterIndication>();
            Jn1s = new HashSet<Jn1>();
            JnCommissions = new HashSet<JnCommission>();
            JnStornos = new HashSet<JnStorno>();
            PayJns = new HashSet<PayJn>();
            PaymentMoreFixedSums = new HashSet<PaymentMoreFixedSum>();
            ReesterRecords = new HashSet<ReesterRecord>();
            Request1s = new HashSet<Request1>();
            Requests = new HashSet<Request>();
        }

        public long Id { get; set; }
        public long UserId { get; set; }
        public int TypeId { get; set; }
        public int? SubTypeId { get; set; }
        public long? DocId { get; set; }
        public string Comment { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long? CalcId { get; set; }
        public long? AccountId { get; set; }
        public long? PaymentAgentId { get; set; }
        public long? TransactionNumber { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ReesterNumber { get; set; }
        public DateTime? ReesterDate { get; set; }
        public string Terminal { get; set; }
        public DateTime? IncomingTransferDate { get; set; }
        public string IncomingTransferNumber { get; set; }
        public string IncomingTransferPack { get; set; }
        public string OperatorName { get; set; }
        public bool UsePaymentDate { get; set; }
        public bool? IsUseRecalc { get; set; }
        public long? PaymentOrderPackId { get; set; }
        public bool NoticeRecalcUseByPeriod { get; set; }
        public long? ArrivalBankAccountId { get; set; }
        public long? PaymentOrderId { get; set; }
        public long? BankPaymentOrderId { get; set; }
        public DateTime? BankPaymentOrderDate { get; set; }
        public DateTime? ReesterRecordPaymentDate { get; set; }
        public bool? PayCurrentReceipt { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public long? DebtActionId { get; set; }
        public int? SubService { get; set; }
        public long? PaymentSystemId { get; set; }
        public long? OldId { get; set; }
        public long? CreditOrgId { get; set; }
        public long? FiscalDoc { get; set; }
        public long? PayFiscalId { get; set; }
        public DateTime? PayFiscalDate { get; set; }
        public long? DebtAffairOwnerId { get; set; }

        public virtual DebtAction DebtAction { get; set; }
        public virtual OrgDocument Doc { get; set; }
        public virtual Organization1 PaymentAgent { get; set; }
        public virtual PaymentOrder PaymentOrder { get; set; }
        public virtual PaymentSystem PaymentSystem { get; set; }
        public virtual FasetItem SubType { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<AccountServicePenaltyRemission> AccountServicePenaltyRemissions { get; set; }
        public virtual ICollection<AccountServiceSubQuality> AccountServiceSubQualities { get; set; }
        public virtual ICollection<AccountServiceSuspension> AccountServiceSuspensions { get; set; }
        public virtual ICollection<AccountServiceTransfer> AccountServiceTransfers { get; set; }
        public virtual ICollection<ApartmentCounterIndication1> ApartmentCounterIndication1s { get; set; }
        public virtual ICollection<ApartmentCounterVolume> ApartmentCounterVolumes { get; set; }
        public virtual ICollection<BankPaymentOrdersRecord> BankPaymentOrdersRecords { get; set; }
        public virtual ICollection<DebtAccountAttachPayment> DebtAccountAttachPayments { get; set; }
        public virtual ICollection<GroupOperCalcCounterParam> GroupOperCalcCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam1> GroupOperCalcHouseCounterParam1s { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam> GroupOperCalcHouseCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcParam1> GroupOperCalcParam1s { get; set; }
        public virtual ICollection<GroupOperationSequence> GroupOperationSequenceChildren { get; set; }
        public virtual ICollection<GroupOperationSequence> GroupOperationSequenceParents { get; set; }
        public virtual ICollection<HouseCounterDeltum> HouseCounterDelta { get; set; }
        public virtual ICollection<HouseCounterIndication> HouseCounterIndications { get; set; }
        public virtual ICollection<Jn1> Jn1s { get; set; }
        public virtual ICollection<JnCommission> JnCommissions { get; set; }
        public virtual ICollection<JnStorno> JnStornos { get; set; }
        public virtual ICollection<PayJn> PayJns { get; set; }
        public virtual ICollection<PaymentMoreFixedSum> PaymentMoreFixedSums { get; set; }
        public virtual ICollection<ReesterRecord> ReesterRecords { get; set; }
        public virtual ICollection<Request1> Request1s { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}
