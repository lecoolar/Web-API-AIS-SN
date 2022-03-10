using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CanonicalServiceSettingsView
    {
        public long Id { get; set; }
        public short FasetId { get; set; }
        public string FassetName { get; set; }
    }
}
