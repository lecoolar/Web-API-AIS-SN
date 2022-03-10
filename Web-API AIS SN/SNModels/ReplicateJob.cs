using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReplicateJob
    {
        public ReplicateJob()
        {
            ReplicateJobParameters = new HashSet<ReplicateJobParameter>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public int StatusId { get; set; }

        public virtual ICollection<ReplicateJobParameter> ReplicateJobParameters { get; set; }
    }
}
