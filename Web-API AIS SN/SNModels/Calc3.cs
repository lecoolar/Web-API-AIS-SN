using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Calc3
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public decimal? CalcTime { get; set; }
        public int? UseResidentVacations { get; set; }
        public bool? IsSubCalc { get; set; }
        public long? ParentCalcId { get; set; }
        public bool? IsFromPayment { get; set; }
        public decimal? FinalTime { get; set; }
        public bool IsSaveGroupOperCalcParams { get; set; }
        public int? SubCalcServices { get; set; }
        public int? CountApartment { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
