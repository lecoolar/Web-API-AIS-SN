using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentHousekeepingsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmenNumber { get; set; }
        public int TypeHk { get; set; }
        public string TypeHkName { get; set; }
        public decimal SquareHk { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public string NameHk { get; set; }
    }
}
