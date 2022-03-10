using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtListNotice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string ProcedureName { get; set; }
        public bool? IsAddDebtActionHistory { get; set; }
        public bool? IsPayNotices { get; set; }
        public bool? IsColDayPerformance { get; set; }
        public bool? IsMinCountDebt { get; set; }
        public int TypeNotices { get; set; }
        public bool IsActivity { get; set; }
        public bool? IsExcel { get; set; }
        public string Comment { get; set; }
        public bool? IsPartOneIndex { get; set; }
        public bool? IsMonitor { get; set; }
        public bool? IsCodeTypePayment { get; set; }
        public bool? IsWord { get; set; }
        public bool? IsJudgeOrg { get; set; }
        public string SynonymName { get; set; }
        public bool? FromDateToDate { get; set; }
        public bool? WithColdDebt { get; set; }
        public bool? IsServiceProvider { get; set; }
        public bool? IsServiceType { get; set; }
        public bool? IsService { get; set; }
        public bool? IsPaymentToDate { get; set; }
        public bool? IsDebitorsView { get; set; }
        public bool? IsPdf { get; set; }
    }
}
