using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ApartmentCounterIndicationsViewService
    {
        public long Id { get; set; }
        public long CounterId { get; set; }
        public decimal Val { get; set; }
        public int ValType { get; set; }
        public string ValTypeName { get; set; }
        public DateTime ValDate { get; set; }
        public DateTime Created { get; set; }
        public long? GroupOperId { get; set; }
    }
}
