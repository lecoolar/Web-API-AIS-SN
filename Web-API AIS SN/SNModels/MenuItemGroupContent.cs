using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class MenuItemGroupContent
    {
        public int Id { get; set; }
        public int MenuItemGroupId { get; set; }
        public int MenuItemId { get; set; }
        public bool Enable { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual MenuItemGroup MenuItemGroup { get; set; }
    }
}
