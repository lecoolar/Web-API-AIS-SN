using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class GroupsAndOptionsView
    {
        public long Id { get; set; }
        public long IdOption { get; set; }
        public string NameOption { get; set; }
        public long IdGroup { get; set; }
        public string NameGroup { get; set; }
        public long IdLevel { get; set; }
        public string NameLevel { get; set; }
        public long IdObject { get; set; }
        public bool? IsActiv { get; set; }
    }
}
