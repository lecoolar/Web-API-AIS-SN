using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentOwnersWithApartmentInfoView
    {
        public long? ParentAddress { get; set; }
        public string Fio { get; set; }
        public string OwnerNumber { get; set; }
        public string SerDoc { get; set; }
        public string NumDoc { get; set; }
        public string OrgDoc { get; set; }
        public DateTime? DateDoc { get; set; }
        public decimal? ApartmentSquare { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentShare { get; set; }
        public int? ApartmentResidentsCount { get; set; }
        public string ApartmentNo { get; set; }
    }
}
