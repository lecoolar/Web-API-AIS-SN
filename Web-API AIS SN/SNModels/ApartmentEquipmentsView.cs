using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentEquipmentsView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string ApartmentName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Info { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public string SerialNumber { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
    }
}
