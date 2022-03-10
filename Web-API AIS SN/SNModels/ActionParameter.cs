using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionParameter
    {
        public long Id { get; set; }
        public long ActionId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string PrintName { get; set; }
        public string PrintValue { get; set; }

        public virtual Action Action { get; set; }
    }
}
