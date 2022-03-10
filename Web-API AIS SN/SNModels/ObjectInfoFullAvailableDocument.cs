using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ObjectInfoFullAvailableDocument
    {
        public string CadNumber { get; set; }
        public string DocType { get; set; }
        public bool DocAvailable { get; set; }
        public decimal DocPrice { get; set; }

        public virtual ObjectInfoFull CadNumberNavigation { get; set; }
        public virtual DocumentType DocTypeNavigation { get; set; }
    }
}
