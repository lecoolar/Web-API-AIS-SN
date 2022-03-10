using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ActionsView
    {
        public long Id { get; set; }
        public int? GroupFasetId { get; set; }
        public DateTime Created { get; set; }
        public long? CanceledAction { get; set; }
        public long? ObjectId { get; set; }
        public int? ObjectTypeFasetId { get; set; }
        public string GroupFasetName { get; set; }
        public string ObjectTypeFasetName { get; set; }
    }
}
