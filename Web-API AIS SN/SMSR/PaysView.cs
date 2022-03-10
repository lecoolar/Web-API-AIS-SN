using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PaysView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public string Phone { get; set; }
        public long? PhoneId { get; set; }
        public long? OrderId { get; set; }
        public string SessionId { get; set; }
        public decimal? Summa { get; set; }
        public decimal? Comm { get; set; }
        public byte? Status { get; set; }
        public string Accpu { get; set; }
        public string Service { get; set; }
        public long? ReqId { get; set; }
        public DateTime? DatePay { get; set; }
        public string RespondBank { get; set; }
        public string Name { get; set; }
        public DateTime? Period { get; set; }
        public int? AgentId { get; set; }
        public string TransactionNumber { get; set; }
        public string RespondBilling { get; set; }
        public string TypePay { get; set; }
        public string CertName { get; set; }
        public string PathCert { get; set; }
        public string RequestBilling { get; set; }
        public string TrxId { get; set; }
        public string BankAccount { get; set; }
        public long? PspackId { get; set; }
        public Guid? Guid { get; set; }
        public string AgentName { get; set; }
    }
}
