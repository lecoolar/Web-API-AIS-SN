using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Group
    {
        public Group()
        {
            Elements = new HashSet<Element>();
            GroupsAndOptions = new HashSet<GroupsAndOption>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long IdLevel { get; set; }

        public virtual Level IdLevelNavigation { get; set; }
        public virtual ICollection<Element> Elements { get; set; }
        public virtual ICollection<GroupsAndOption> GroupsAndOptions { get; set; }
    }
}
