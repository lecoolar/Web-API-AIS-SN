using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountPeriodFkr
    {
        public long Id { get; set; }
        public string AcodeOrgUnit { get; set; }
        public string AbonentId { get; set; }
        public string AccountPayableNmb { get; set; }
        public string MonthYearToWord { get; set; }
        public string Aindex { get; set; }
        public string Address { get; set; }
        public string TariffDay { get; set; }
        public string SumCalculateDay { get; set; }
        public string DebtDiscounted { get; set; }
        public string PrivSum { get; set; }
        public string SumReccreate { get; set; }
        public string Fine { get; set; }
        public string SumFine { get; set; }
        public string NormativDate { get; set; }
        public string AccountPerB { get; set; }
        public string AccountPerE { get; set; }
        public string InfoDop { get; set; }
        public string SumCalculate { get; set; }
        public string SumDiscounted { get; set; }
        public string DebtEndPeriod { get; set; }
        public string DebtFine { get; set; }
    }
}
