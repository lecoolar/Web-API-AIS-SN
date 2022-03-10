using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentArea
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Dateb { get; set; }
        public decimal? Total { get; set; }
        public decimal? Living { get; set; }
        public decimal? Heating { get; set; }
        public decimal? Balcony { get; set; }
        public DateTime Datec { get; set; }
        public long? DocId { get; set; }

        public virtual Apartment1 Apartment { get; set; }
    }
}
