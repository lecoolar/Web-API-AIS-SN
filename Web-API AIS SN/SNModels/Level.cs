using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Level
    {
        public Level()
        {
            Groups = new HashSet<Group>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
    }
}
