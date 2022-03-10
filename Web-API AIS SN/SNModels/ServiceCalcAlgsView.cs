using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceCalcAlgsView
    {
        public long Id { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public long CalcAlgId { get; set; }
        public string CalcAlgName { get; set; }
        public string ChargeFormulaName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public string Formula { get; set; }
        public string ProcName { get; set; }
    }
}
