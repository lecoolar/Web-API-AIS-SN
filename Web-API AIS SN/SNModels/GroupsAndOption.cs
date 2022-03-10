using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupsAndOption
    {
        public long Id { get; set; }
        public long IdOption { get; set; }
        public long IdGroup { get; set; }
        public bool? IsActiv { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool ShowMessageOutOfPeriod { get; set; }
        public string Message { get; set; }

        public virtual Group IdGroupNavigation { get; set; }
        public virtual Option IdOptionNavigation { get; set; }
    }
}
