using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ExportToHmWebJnRep
    {
        public int Id { get; set; }
        public DateTime? Month { get; set; }
        public long? HouseAdrId { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? ProviderId { get; set; }
        public long? HouseHolderId { get; set; }
        public bool? IsResidential { get; set; }
        public decimal? SaldoBeg { get; set; }
        public decimal? Charged { get; set; }
        public decimal? Recalculation { get; set; }
        public decimal? Raised { get; set; }
        public decimal? SaldoEnd { get; set; }
        public DateTime? Created { get; set; }
        public decimal? ChargePeny { get; set; }
        public decimal? PaymentPeny { get; set; }
    }
}
