using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T82038Apartment
    {
        public long Id { get; set; }
        public long? HouseId { get; set; }
        public string Number { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public long AdrId { get; set; }
        public int? FloorHouse { get; set; }
        public int? DoorWay { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public DateTime Datec { get; set; }
        public byte? RoomsCount { get; set; }
        public string EnergoAccount { get; set; }
        public string Phone { get; set; }
        public long? ToDateDocId { get; set; }
        public byte? FloorsCount { get; set; }
        public string TLoad { get; set; }
        public string Phone2 { get; set; }
        public string CadastralNumber { get; set; }
        public int? OkvedTypeId { get; set; }
        public int? ObjectCategoryId { get; set; }
        public decimal? VolumeTko { get; set; }
    }
}
