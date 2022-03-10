using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Right
    {
        public Right()
        {
            ModuleRights = new HashSet<ModuleRight>();
            RightGroupGroups = new HashSet<RightGroup>();
            RightGroupRights = new HashSet<RightGroup>();
            UserRights = new HashSet<UserRight>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }

        public virtual RightType Type { get; set; }
        public virtual ICollection<ModuleRight> ModuleRights { get; set; }
        public virtual ICollection<RightGroup> RightGroupGroups { get; set; }
        public virtual ICollection<RightGroup> RightGroupRights { get; set; }
        public virtual ICollection<UserRight> UserRights { get; set; }
    }
}
