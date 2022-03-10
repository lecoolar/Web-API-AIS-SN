using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class TblDeathPerson
    {
        public long? Id { get; set; }
        public string Adrown { get; set; }
        public string Adrres { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public string Birthdate { get; set; }
        public string Datemorto { get; set; }
        public string Dateexit { get; set; }
        public long? Apartmentid { get; set; }
        public long? Personid { get; set; }
        public string Err { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Tmpadr { get; set; }
        public long? Adrownid { get; set; }
    }
}
