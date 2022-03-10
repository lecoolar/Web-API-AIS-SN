using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class PaymentOrderTemplate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string ProcedureName { get; set; }
        public bool? IsAddDebtActionHistory { get; set; }
        public bool? IsPayNotices { get; set; }
        public bool? IsColDayPerformance { get; set; }
        public bool? IsMinCountDebt { get; set; }
        public int? TypeNotices { get; set; }
        public bool IsActivity { get; set; }
        public bool? IsExcel { get; set; }
        public string Comment { get; set; }
        public bool? IsPartOneIndex { get; set; }
        public bool? IsMonitor { get; set; }
        public bool? IsCodeTypePayment { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsReport { get; set; }
        public bool? IsSave { get; set; }
        public bool? IsAddReportFilters { get; set; }
    }
}
