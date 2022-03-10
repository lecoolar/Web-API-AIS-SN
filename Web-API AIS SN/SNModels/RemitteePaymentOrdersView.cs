using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RemitteePaymentOrdersView
    {
        public long Id { get; set; }
        public long RemitteeId { get; set; }
        public long RemitteeOrgId { get; set; }
        public string RemitteeOrgShortName { get; set; }
        public long ClientDocOrgId { get; set; }
        public string ClientDocOrgName { get; set; }
        public string Number { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Summ { get; set; }
        public DateTime Created { get; set; }
    }
}
