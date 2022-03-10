using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ServiceSplitJnTransfer
    {
        public long Id { get; set; }
        public long SplitJnId { get; set; }
        public DateTime TransferDate { get; set; }
        public decimal Summ { get; set; }

        public virtual ServiceSplitJn SplitJn { get; set; }
    }
}
