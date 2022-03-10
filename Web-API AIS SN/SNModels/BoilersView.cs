using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BoilersView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? OrganizationId { get; set; }
        public DateTime? Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime? Datec { get; set; }
        public string ShortName { get; set; }
    }
}
