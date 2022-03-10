using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PollAnswer
    {
        public PollAnswer()
        {
            PollVotingRecords = new HashSet<PollVotingRecord>();
        }

        public int Id { get; set; }
        public int PollId { get; set; }
        public string Name { get; set; }
        public int NumberOfVotes { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Poll Poll { get; set; }
        public virtual ICollection<PollVotingRecord> PollVotingRecords { get; set; }
    }
}
