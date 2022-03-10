using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionNotice
    {
        public DebtActionNotice()
        {
            DebtActionNoticesExecProcIdDateHistories = new HashSet<DebtActionNoticesExecProcIdDateHistory>();
            DebtExecutoryProcessStages = new HashSet<DebtExecutoryProcessStage>();
            DebtRecoveredAmounts = new HashSet<DebtRecoveredAmount>();
        }

        public long Id { get; set; }
        public long DebtActionId { get; set; }
        public int TypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Creared { get; set; }
        public string ResultComment { get; set; }
        public int? ExecutionTime { get; set; }
        public string ScanPath { get; set; }
        public string NameNotice { get; set; }
        public bool? Served { get; set; }
        public bool? Court { get; set; }
        public bool? NotReportExecutionTime { get; set; }
        public int? NoticeResultId { get; set; }
        public string CourtNumberAffair { get; set; }
        public string CourtNumberDecisions { get; set; }
        public string NumberPerformSheet { get; set; }
        public DateTime? DatePerformSheet { get; set; }
        public int? QuantityPerformSheets { get; set; }
        public string CourtNameDistrict { get; set; }
        public DateTime? DateDecision { get; set; }
        public DateTime? DateCancelOfDecision { get; set; }
        public DateTime? InstDateDecree { get; set; }
        public string InstResultConsideration { get; set; }
        public DateTime? DatePfexecProc { get; set; }
        public DateTime? DateUfsspexecProc { get; set; }
        public string NameUfsspexecProc { get; set; }
        public DateTime? DateProcessInstance { get; set; }
        public string InitiatorInstance { get; set; }
        public DateTime? DateAbsentia { get; set; }
        public DateTime? DateMeetingFi { get; set; }
        public string DocStopExecProc { get; set; }
        public DateTime? DateStartExecProc { get; set; }
        public DateTime? DateTransferPerformSheet { get; set; }
        public DateTime? DateResultConsideration { get; set; }
        public string Fioworker { get; set; }
        public DateTime? DateApplicationPerformSheet { get; set; }
        public DateTime? DateReceivingPerformSheet { get; set; }
        public decimal? GosposhlinaReturn { get; set; }
        public string AmicableAgreement { get; set; }
        public long? UserId { get; set; }
        public string ExecProcNumber { get; set; }
        public string StructDivision { get; set; }
        public int? ExecProcStatus { get; set; }
        public string ExecProcIdperiod { get; set; }
        public DateTime? ExecProcIddate { get; set; }
        public string ExecProcBankName { get; set; }
        public DateTime? ExecProcIddateReturn { get; set; }
        public DateTime? ExecProcIddateSsp { get; set; }
        public string ExecProcInfo { get; set; }
        public DateTime? ExecProcDateStopOutRf { get; set; }
        public DateTime? ExecProcDateReturnPfr { get; set; }
        public string DebtActionNumber { get; set; }
        public long? DebtListNoticeId { get; set; }
        public long? ApartmentOwnerId { get; set; }
        public DateTime? DateResubmissionApplication { get; set; }
        public DateTime? InternalTrainingPeriod { get; set; }
        public DateTime? NormativeFilingPeriod { get; set; }
        public DateTime? ActualFilingDate { get; set; }
        public string PaymentBeforeFiling { get; set; }
        public string OutcomeOfTheTrial { get; set; }
        public string PaymentBeforeReceipt { get; set; }
        public string NameOfAuthority { get; set; }
        public DateTime? DateChange { get; set; }
        public DateTime? DateDecisionFi { get; set; }
        public DateTime? DateDecisionSi { get; set; }
        public DateTime? DateDecisionTi { get; set; }
        public int? InstResultConsiderationFi { get; set; }
        public int? InstResultConsiderationSi { get; set; }
        public int? InstResultConsiderationTi { get; set; }
        public DateTime? DateProcessInstanceSi { get; set; }
        public DateTime? DateProcessInstanceTi { get; set; }
        public string InitiatorInstanceSi { get; set; }
        public string InitiatorInstanceTi { get; set; }
        public string DateResultConsiderationSi { get; set; }
        public string DateResultConsiderationTi { get; set; }
        public string SerialNumber1 { get; set; }
        public string SerialNumber2 { get; set; }
        public string SerialNumber3 { get; set; }
        public string SerialNumber4 { get; set; }
        public DateTime? SerialDate1 { get; set; }
        public DateTime? SerialDate2 { get; set; }
        public DateTime? SerialDate3 { get; set; }
        public DateTime? SerialDate4 { get; set; }
        public string WhoPaysGosposhlina { get; set; }
        public int? CasePending { get; set; }
        public DateTime? DateOfIssueDefinition { get; set; }
        public int? ReviewResult { get; set; }
        public string ReasonsForReturning { get; set; }
        public int? ExplanationOfReasonForRejection { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? NormativeTermForIssuing { get; set; }
        public DateTime? DateOfActualReceipt { get; set; }
        public decimal? PaymentBeforeFilingAclaim { get; set; }
        public decimal? PaymentBeforeReceiving { get; set; }
        public DateTime? DateOfApplicationOnReceipt { get; set; }
        public DateTime? AppealMeetingDate { get; set; }
        public DateTime? DateMeetingPrPr { get; set; }
        public DateTime? DateOfCassationMeeting { get; set; }
        public DateTime? F9DpDateDebtPeriodFd { get; set; }
        public DateTime? F9DpDateDebtPeriodTd { get; set; }
        public DateTime? F25DpDateDebtPeriodFd { get; set; }
        public DateTime? F25DpDateDebtPeriodTd { get; set; }
        public decimal? F10NudSumIsk { get; set; }
        public decimal? F26NudSumIsk { get; set; }
        public decimal? F27NudSumIsk { get; set; }
        public decimal? F41NudSumIsk { get; set; }
        public decimal? F45NudSumIsk { get; set; }
        public decimal? F60NudSumIsk { get; set; }
        public decimal? F64NudSumIsk { get; set; }
        public decimal? F75NudSumIsk { get; set; }
        public decimal? F79NudSumIsk { get; set; }
        public decimal? F11NudDebtSumm { get; set; }
        public decimal? F28NudDebtSumm { get; set; }
        public decimal? F42NudDebtSumm { get; set; }
        public decimal? F46NudDebtSumm { get; set; }
        public decimal? F61NudDebtSumm { get; set; }
        public decimal? F65NudDebtSumm { get; set; }
        public decimal? F76NudDebtSumm { get; set; }
        public decimal? F80NudDebtSumm { get; set; }
        public decimal? F12NudDebtPeni { get; set; }
        public decimal? F29NudDebtPeni { get; set; }
        public decimal? F43NudDebtPeni { get; set; }
        public decimal? F47NudDebtPeni { get; set; }
        public decimal? F62NudDebtPeni { get; set; }
        public decimal? F66NudDebtPeni { get; set; }
        public decimal? F77NudDebtPeni { get; set; }
        public decimal? F81NudDebtPeni { get; set; }
        public decimal? F13NudGosposhlina { get; set; }
        public decimal? F14NudGosposhlina { get; set; }
        public decimal? F17NudGosposhlina { get; set; }
        public decimal? F30NudGosposhlina { get; set; }
        public decimal? F44NudGosposhlina { get; set; }
        public decimal? F48NudGosposhlina { get; set; }
        public decimal? F63NudGosposhlina { get; set; }
        public decimal? F67NudGosposhlina { get; set; }
        public decimal? F78NudGosposhlina { get; set; }
        public decimal? F82NudGosposhlina { get; set; }
        public decimal? F33NudRecoveredAmountSummPrPr { get; set; }
        public int? Cause { get; set; }
        public int? SourcePayment { get; set; }
        public int? ReasonReturn { get; set; }
        public bool? SignSend { get; set; }
        public DateTime? DateSend { get; set; }
        public bool? SignReceipt { get; set; }
        public DateTime? DateReceipt { get; set; }
        public decimal? PaymentNumber { get; set; }
        public DateTime? DatePayment { get; set; }
        public string NameOfTheExecutiveDocument { get; set; }
        public DateTime? DateOfExecutiveDocument { get; set; }
        public string PlaceOfExecutiveDocument { get; set; }
        public string AimedAtCollection { get; set; }
        public DateTime? DateOfSendingForCollection { get; set; }
        public DateTime? DateOfReturnOfTheCourtOrder { get; set; }
        public string ReasonForTheReturnOfTheCourtOrder { get; set; }
        public DateTime? DateOfPaymentOfStateDuty { get; set; }

        public virtual FasetItem CauseNavigation { get; set; }
        public virtual DebtAction DebtAction { get; set; }
        public virtual FasetItem NoticeResult { get; set; }
        public virtual FasetItem ReasonReturnNavigation { get; set; }
        public virtual FasetItem SourcePaymentNavigation { get; set; }
        public virtual FasetItem Type { get; set; }
        public virtual ICollection<DebtActionNoticesExecProcIdDateHistory> DebtActionNoticesExecProcIdDateHistories { get; set; }
        public virtual ICollection<DebtExecutoryProcessStage> DebtExecutoryProcessStages { get; set; }
        public virtual ICollection<DebtRecoveredAmount> DebtRecoveredAmounts { get; set; }
    }
}
