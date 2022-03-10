using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Jn1
    {
        public Jn1()
        {
            BankPaymentOrderRecordJns = new HashSet<BankPaymentOrderRecordJn>();
            DebtAccountAttachCharges = new HashSet<DebtAccountAttachCharge>();
            DebtAccountAttachPayments = new HashSet<DebtAccountAttachPayment>();
            JnBankPaymentOrderOutputs = new HashSet<JnBankPaymentOrderOutput>();
            JnBenefit1s = new HashSet<JnBenefit1>();
            JnCalcCounterParams = new HashSet<JnCalcCounterParam>();
            JnCalcHouseCounterParams = new HashSet<JnCalcHouseCounterParam>();
            JnCalcParams = new HashSet<JnCalcParam>();
            JnPenalties = new HashSet<JnPenalty>();
            JnPenaltyByDays = new HashSet<JnPenaltyByDay>();
        }

        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Period { get; set; }
        public decimal Summ { get; set; }
        public byte CalcOperId { get; set; }
        public long? GroupOperId { get; set; }
        public long? RemitteePaymentOrderId { get; set; }
        public long? BankPaymentOrderRecordInputId { get; set; }
        public long? BankPaymentOrderRecordOutputId { get; set; }
        public long? OldId { get; set; }

        public virtual AccountService4 AccountService { get; set; }
        public virtual CalcOperation CalcOper { get; set; }
        public virtual GroupOperation GroupOper { get; set; }
        public virtual RemitteePaymentOrder RemitteePaymentOrder { get; set; }
        public virtual JnStorno JnStornoInitialJn { get; set; }
        public virtual JnStorno JnStornoStornoJn { get; set; }
        public virtual ICollection<BankPaymentOrderRecordJn> BankPaymentOrderRecordJns { get; set; }
        public virtual ICollection<DebtAccountAttachCharge> DebtAccountAttachCharges { get; set; }
        public virtual ICollection<DebtAccountAttachPayment> DebtAccountAttachPayments { get; set; }
        public virtual ICollection<JnBankPaymentOrderOutput> JnBankPaymentOrderOutputs { get; set; }
        public virtual ICollection<JnBenefit1> JnBenefit1s { get; set; }
        public virtual ICollection<JnCalcCounterParam> JnCalcCounterParams { get; set; }
        public virtual ICollection<JnCalcHouseCounterParam> JnCalcHouseCounterParams { get; set; }
        public virtual ICollection<JnCalcParam> JnCalcParams { get; set; }
        public virtual ICollection<JnPenalty> JnPenalties { get; set; }
        public virtual ICollection<JnPenaltyByDay> JnPenaltyByDays { get; set; }
    }
}
