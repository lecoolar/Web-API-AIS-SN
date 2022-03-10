using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebAcknowledgement
    {
        public long TransportAcknowledgementId { get; set; }
        public long RemotePaymentDocumentIncomeId { get; set; }
        public long RemoteOrderOrganizationId { get; set; }
        public string OrderNumber { get; set; }
        public long Amount { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset Updated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
