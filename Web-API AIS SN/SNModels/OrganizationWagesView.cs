using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrganizationWagesView
    {
        public long Id { get; set; }
        public int ProfessionId { get; set; }
        public long Rank { get; set; }
        public long OrganizationId { get; set; }
        public decimal Wage { get; set; }
        public string ProfessionName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
