using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserProperty
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int PropertiesId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
    }
}
