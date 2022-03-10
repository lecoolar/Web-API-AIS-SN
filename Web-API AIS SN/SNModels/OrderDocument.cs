using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class OrderDocument
    {
        public int TransactionId { get; set; }
        public string DocType { get; set; }
        public int DocumentId { get; set; }
        public byte Status { get; set; }
        public string XmlText { get; set; }

        public virtual DocumentType DocTypeNavigation { get; set; }
        public virtual Order Transaction { get; set; }
    }
}
