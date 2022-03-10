using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountService4
    {
        public AccountService4()
        {
            AccountServiceCounter1s = new HashSet<AccountServiceCounter1>();
            AccountServiceDocuments = new HashSet<AccountServiceDocument>();
            AccountServiceEquipments = new HashSet<AccountServiceEquipment>();
            AccountServiceJudgments = new HashSet<AccountServiceJudgment>();
            AccountServiceNorms = new HashSet<AccountServiceNorm>();
            AccountServicePaymentInstallments = new HashSet<AccountServicePaymentInstallment>();
            AccountServicePenaltyRemissions = new HashSet<AccountServicePenaltyRemission>();
            AccountServiceRelationAccountServices = new HashSet<AccountServiceRelation>();
            AccountServiceRelationParents = new HashSet<AccountServiceRelation>();
            AccountServiceSubQualities = new HashSet<AccountServiceSubQuality>();
            AccountServiceSuspensions = new HashSet<AccountServiceSuspension>();
            AccountServiceTariffs = new HashSet<AccountServiceTariff>();
            AccountServiceTransferAccountServiceNews = new HashSet<AccountServiceTransfer>();
            AccountServiceTransferAccountServices = new HashSet<AccountServiceTransfer>();
            DebtAccountServices = new HashSet<DebtAccountService>();
            GroupOperCalcCounterParams = new HashSet<GroupOperCalcCounterParam>();
            GroupOperCalcHouseCounterParam1s = new HashSet<GroupOperCalcHouseCounterParam1>();
            GroupOperCalcHouseCounterParams = new HashSet<GroupOperCalcHouseCounterParam>();
            GroupOperCalcParam1s = new HashSet<GroupOperCalcParam1>();
            Jn1s = new HashSet<Jn1>();
            JnSaldoSumms = new HashSet<JnSaldoSumm>();
            JnSaldos = new HashSet<JnSaldo>();
            PayJns = new HashSet<PayJn>();
        }

        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ServiceId { get; set; }
        public long? HouseHolderId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public long KodCl { get; set; }
        public long KodObj { get; set; }
        public string Guid { get; set; }
        public bool OpenedByError { get; set; }
        public long? OpenDocId { get; set; }
        public long? CloseDocId { get; set; }
        public DateTime? RecalcStartPeriod { get; set; }

        public virtual Account Account { get; set; }
        public virtual OrgDocument CloseDoc { get; set; }
        public virtual Organization1 HouseHolder { get; set; }
        public virtual OrgDocument OpenDoc { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ICollection<AccountServiceCounter1> AccountServiceCounter1s { get; set; }
        public virtual ICollection<AccountServiceDocument> AccountServiceDocuments { get; set; }
        public virtual ICollection<AccountServiceEquipment> AccountServiceEquipments { get; set; }
        public virtual ICollection<AccountServiceJudgment> AccountServiceJudgments { get; set; }
        public virtual ICollection<AccountServiceNorm> AccountServiceNorms { get; set; }
        public virtual ICollection<AccountServicePaymentInstallment> AccountServicePaymentInstallments { get; set; }
        public virtual ICollection<AccountServicePenaltyRemission> AccountServicePenaltyRemissions { get; set; }
        public virtual ICollection<AccountServiceRelation> AccountServiceRelationAccountServices { get; set; }
        public virtual ICollection<AccountServiceRelation> AccountServiceRelationParents { get; set; }
        public virtual ICollection<AccountServiceSubQuality> AccountServiceSubQualities { get; set; }
        public virtual ICollection<AccountServiceSuspension> AccountServiceSuspensions { get; set; }
        public virtual ICollection<AccountServiceTariff> AccountServiceTariffs { get; set; }
        public virtual ICollection<AccountServiceTransfer> AccountServiceTransferAccountServiceNews { get; set; }
        public virtual ICollection<AccountServiceTransfer> AccountServiceTransferAccountServices { get; set; }
        public virtual ICollection<DebtAccountService> DebtAccountServices { get; set; }
        public virtual ICollection<GroupOperCalcCounterParam> GroupOperCalcCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam1> GroupOperCalcHouseCounterParam1s { get; set; }
        public virtual ICollection<GroupOperCalcHouseCounterParam> GroupOperCalcHouseCounterParams { get; set; }
        public virtual ICollection<GroupOperCalcParam1> GroupOperCalcParam1s { get; set; }
        public virtual ICollection<Jn1> Jn1s { get; set; }
        public virtual ICollection<JnSaldoSumm> JnSaldoSumms { get; set; }
        public virtual ICollection<JnSaldo> JnSaldos { get; set; }
        public virtual ICollection<PayJn> PayJns { get; set; }
    }
}
