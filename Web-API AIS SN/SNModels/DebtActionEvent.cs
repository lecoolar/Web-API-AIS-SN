using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionEvent
    {
        public long Id { get; set; }
        public int? TypeEvent { get; set; }
        public long? DebtActionId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TypeResult { get; set; }

        public virtual DebtAction DebtAction { get; set; }
        public virtual FasetItem TypeEventNavigation { get; set; }
        public virtual FasetItem TypeResultNavigation { get; set; }
    }
}
