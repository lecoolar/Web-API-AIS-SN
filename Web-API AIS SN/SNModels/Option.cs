using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Option
    {
        public Option()
        {
            GroupsAndOptions = new HashSet<GroupsAndOption>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<GroupsAndOption> GroupsAndOptions { get; set; }
    }
}
