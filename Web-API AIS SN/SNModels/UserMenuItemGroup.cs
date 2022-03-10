using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class UserMenuItemGroup
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public int MenuItemGroupId { get; set; }

        public virtual MenuItemGroup MenuItemGroup { get; set; }
        public virtual User User { get; set; }
    }
}
