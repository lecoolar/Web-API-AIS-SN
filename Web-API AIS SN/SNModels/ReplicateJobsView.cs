using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJobsView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public int? PartsCount { get; set; }
        public int PartsResultCount { get; set; }
        public decimal? PartsPercentDone { get; set; }
    }
}
