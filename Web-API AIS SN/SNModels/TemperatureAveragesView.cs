using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TemperatureAveragesView
    {
        public long Id { get; set; }
        public DateTime FromDate { get; set; }
        public decimal Temperature { get; set; }
        public long? AreaId { get; set; }
        public DateTime Created { get; set; }
        public string Adrname { get; set; }
        public int? StatusTemporary { get; set; }
    }
}
