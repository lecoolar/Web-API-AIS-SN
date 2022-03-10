using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CalcServicesHousekeepingsByDay
    {
        public long Id { get; set; }
        public long CalcId { get; set; }
        public long ApartmentId { get; set; }
        public DateTime Period { get; set; }
        public DateTime? RangeStart { get; set; }
        public int TypeId { get; set; }
        public decimal Square { get; set; }
    }
}
