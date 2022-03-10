using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCanonicalTypesView
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public int? TypeId { get; set; }
        public string TypeName { get; set; }
        public short? FasetId { get; set; }
        public string FasetName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? Created { get; set; }
    }
}
