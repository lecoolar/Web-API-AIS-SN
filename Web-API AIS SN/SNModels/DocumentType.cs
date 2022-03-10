using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DocumentType
    {
        public DocumentType()
        {
            ObjectInfoFullAvailableDocuments = new HashSet<ObjectInfoFullAvailableDocument>();
            OrderDocuments = new HashSet<OrderDocument>();
        }

        public string DocType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ObjectInfoFullAvailableDocument> ObjectInfoFullAvailableDocuments { get; set; }
        public virtual ICollection<OrderDocument> OrderDocuments { get; set; }
    }
}
