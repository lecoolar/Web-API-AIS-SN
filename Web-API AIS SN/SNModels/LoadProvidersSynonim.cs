using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class LoadProvidersSynonim
    {
        public long Id { get; set; }
        public long? BillId { get; set; }
        public string ImportCode { get; set; }
        public string ImportName { get; set; }
        public long? LocalOrgId { get; set; }
        public long? UserId { get; set; }
        public DateTime? Created { get; set; }
    }
}
