using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RequestGate
    {
        public long Id { get; set; }
        public long? RequestId { get; set; }
        public string RequestXml { get; set; }
        public int? StatusId { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public string Error { get; set; }
        public string Organization { get; set; }
        public decimal? PaidSumm { get; set; }
        public DateTime Created { get; set; }
        public long? CheckRequestId { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionNumberStorno { get; set; }
        public string Comment { get; set; }
        public long? ReesterRecordId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ReesterRecord ReesterRecord { get; set; }
        public virtual Request1 Request { get; set; }
        public virtual FasetItem Status { get; set; }
    }
}
