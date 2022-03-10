using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseBankAccountServiceTypesView
    {
        public long Id { get; set; }
        public long HouseBankAccountId { get; set; }
        public long BankAccountId { get; set; }
        public long ServiceId { get; set; }
        public int ServiceCode { get; set; }
        public string ServiceShortName { get; set; }
        public string ServiceLongName { get; set; }
        public string BankName { get; set; }
        public decimal? AccountNumber { get; set; }
        public DateTime Created { get; set; }
    }
}
