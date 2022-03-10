using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class BankAccountProvidersView
    {
        public long Id { get; set; }
        public long BankAccountId { get; set; }
        public long OrgId { get; set; }
        public string ExternalSystemCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Created { get; set; }
        public string Maskfilename { get; set; }
    }
}
