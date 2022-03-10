using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserAddrAccess
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long AdrId { get; set; }
        public int Level { get; set; }
        public DateTime Created { get; set; }
    }
}
