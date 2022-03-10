using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserRight
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public int RightId { get; set; }

        public virtual Right Right { get; set; }
        public virtual User User { get; set; }
    }
}
