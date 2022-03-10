using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OwnersFromSn
    {
        public string FullName { get; set; }
        public long SnAddressId { get; set; }
        public string Number { get; set; }
        public string Fio { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? SnPersonId { get; set; }
        public DateTime DateBegin { get; set; }
    }
}
