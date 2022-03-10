using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            MenuItemGroupContents = new HashSet<MenuItemGroupContent>();
        }

        public int Id { get; set; }
        public string NameItem { get; set; }
        public string TypeName { get; set; }
        public string ValueName { get; set; }
        public int? ParentId { get; set; }
        public bool Visible { get; set; }

        public virtual ICollection<MenuItemGroupContent> MenuItemGroupContents { get; set; }
    }
}
