using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class MenuItemsView
    {
        public int Id { get; set; }
        public string NameItem { get; set; }
        public string TypeName { get; set; }
        public string ValueName { get; set; }
        public int? ParentId { get; set; }
        public bool Visible { get; set; }
        public int? ExistChild { get; set; }
        public bool? Enable { get; set; }
    }
}
