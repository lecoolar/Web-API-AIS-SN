using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HousePasportNote
    {
        public long Id { get; set; }
        public long HouseId { get; set; }
        public DateTime Created { get; set; }
        public string Caption { get; set; }
        public string Note { get; set; }
        public string UserName { get; set; }
    }
}
