using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BoilersVolumeView
    {
        public long Id { get; set; }
        public int TypeVolume { get; set; }
        public decimal Volume { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime Datee { get; set; }
        public DateTime Datec { get; set; }
        public long BoilerId { get; set; }
        public string Name { get; set; }
    }
}
