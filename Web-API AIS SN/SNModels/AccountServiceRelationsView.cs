using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceRelationsView
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public long AccountServiceId { get; set; }
        public int? AccountServiceCode { get; set; }
        public string AccountServiceName { get; set; }
        public string AccountServiceTypeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public DateTime AccountServiceFromDate { get; set; }
        public DateTime? AccountServiceToDate { get; set; }
    }
}
