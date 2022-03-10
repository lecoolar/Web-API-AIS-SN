using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class Order
    {
        public Order()
        {
            OrderDocuments = new HashSet<OrderDocument>();
        }

        public int TransactionId { get; set; }
        public string CadNumber { get; set; }
        public bool Paid { get; set; }
        public int CreatorId { get; set; }
        public DateTime Created { get; set; }
        public int UpdaterId { get; set; }
        public DateTime Updated { get; set; }

        public virtual ObjectInfoFull CadNumberNavigation { get; set; }
        public virtual ICollection<OrderDocument> OrderDocuments { get; set; }
    }
}
