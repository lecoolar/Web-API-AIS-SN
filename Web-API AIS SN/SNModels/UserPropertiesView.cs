using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserPropertiesView
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public int PropertiesId { get; set; }
        public string PropertiesName { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
    }
}
