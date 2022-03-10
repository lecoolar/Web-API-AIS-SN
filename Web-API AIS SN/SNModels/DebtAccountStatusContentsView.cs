using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountStatusContentsView
    {
        public int Id { get; set; }
        public int DebtAccountStatusId { get; set; }
        public string DebtAccountStatus { get; set; }
        public long StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime Created { get; set; }
    }
}
