using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationMaterialsView
    {
        public long Id { get; set; }
        public int MaterialId { get; set; }
        public long OrganizationId { get; set; }
        public decimal Price { get; set; }
        public string MaterialName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
