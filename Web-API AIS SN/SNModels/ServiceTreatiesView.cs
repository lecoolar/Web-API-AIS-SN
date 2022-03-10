using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceTreatiesView
    {
        public long Id { get; set; }
        public long AdrId { get; set; }
        public string AddressName { get; set; }
        public int? ServiceTypeGroupCode { get; set; }
        public string GroupName { get; set; }
        public long TreatieId { get; set; }
        public string Number { get; set; }
        public DateTime? Date { get; set; }
        public decimal Tariff { get; set; }
        public decimal Count { get; set; }
        public decimal Summ { get; set; }
    }
}
