using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentRoom
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string Number { get; set; }
        public decimal Total { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? Parameter { get; set; }
    }
}
