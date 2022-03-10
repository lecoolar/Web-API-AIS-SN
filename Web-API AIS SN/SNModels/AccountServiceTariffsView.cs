using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountServiceTariffsView
    {
        public long Id { get; set; }
        public long AccountServiceId { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceCode { get; set; }
        public long ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public decimal Rate { get; set; }
        public long? DocId { get; set; }
        public string OrgDocumentName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
