using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class FasetItemsView
    {
        public int Id { get; set; }
        public short FasetId { get; set; }
        public string FasetName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
