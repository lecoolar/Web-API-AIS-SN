using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HolidayAndWeekend
    {
        public long Id { get; set; }
        public DateTime DateHoliday { get; set; }
        public string NameHoliday { get; set; }
        public int? OffsetToWorkingDay { get; set; }
    }
}
