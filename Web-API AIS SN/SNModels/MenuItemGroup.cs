using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class MenuItemGroup
    {
        public MenuItemGroup()
        {
            MenuItemGroupContents = new HashSet<MenuItemGroupContent>();
            UserMenuItemGroups = new HashSet<UserMenuItemGroup>();
        }

        public int Id { get; set; }
        public string GroupItem { get; set; }

        public virtual ICollection<MenuItemGroupContent> MenuItemGroupContents { get; set; }
        public virtual ICollection<UserMenuItemGroup> UserMenuItemGroups { get; set; }
    }
}
