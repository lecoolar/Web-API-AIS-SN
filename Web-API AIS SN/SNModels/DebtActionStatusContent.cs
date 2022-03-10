using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionStatusContent
    {
        public int Id { get; set; }
        public int DebtActionStatusId { get; set; }
        public long StatusId { get; set; }
        public DateTime Created { get; set; }
    }
}
