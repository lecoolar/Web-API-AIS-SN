using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T84139BankAccount
    {
        public long Id { get; set; }
        public string AccountNumber { get; set; }
        public long BankId { get; set; }
        public long OwnerId { get; set; }
        public bool IsPrimary { get; set; }
        public long? Code { get; set; }
        public string ExternalSystemCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? PropertyId { get; set; }
    }
}
