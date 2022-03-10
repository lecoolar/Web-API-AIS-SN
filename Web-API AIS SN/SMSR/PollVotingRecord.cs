using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class PollVotingRecord
    {
        public int Id { get; set; }
        public int PollAnswerId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PollAnswer PollAnswer { get; set; }
    }
}
