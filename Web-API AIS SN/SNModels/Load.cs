using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Load
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public DateTime ValidationDate { get; set; }
        public string Hash { get; set; }
        public DateTime Created { get; set; }
        public long Userid { get; set; }
        public string Filetype { get; set; }
    }
}
