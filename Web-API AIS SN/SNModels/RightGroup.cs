using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class RightGroup
    {
        public int Id { get; set; }
        public int RightId { get; set; }
        public int GroupId { get; set; }

        public virtual Right Group { get; set; }
        public virtual Right Right { get; set; }
    }
}
