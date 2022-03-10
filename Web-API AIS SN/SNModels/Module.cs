using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Module
    {
        public Module()
        {
            ModuleRights = new HashSet<ModuleRight>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ModuleRight> ModuleRights { get; set; }
    }
}
