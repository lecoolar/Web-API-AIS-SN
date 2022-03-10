using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ObjectInfoFull
    {
        public ObjectInfoFull()
        {
            ObjectInfoFullAvailableDocuments = new HashSet<ObjectInfoFullAvailableDocument>();
            Orders = new HashSet<Order>();
        }

        public string CadNumber { get; set; }
        public string EncodedObject { get; set; }
        public int UserId { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<ObjectInfoFullAvailableDocument> ObjectInfoFullAvailableDocuments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
