using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SMSR
{
    public partial class ChatHouse
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public Guid HouseId { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
    }
}
