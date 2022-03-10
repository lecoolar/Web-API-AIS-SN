using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadService
    {
        public long Id { get; set; }
        public long? ProcessingId { get; set; }
        public int? StatusId { get; set; }
        public long? BillId { get; set; }
        public DateTime? CalcPeriod { get; set; }
        public DateTime? UnloadDate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Servicetype { get; set; }
        public string Comment { get; set; }
        public string Error { get; set; }
        public long? Servicetypeid { get; set; }
        public long? Serviceid { get; set; }
    }
}
