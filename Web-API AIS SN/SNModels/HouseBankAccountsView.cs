using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseBankAccountsView
    {
        public long Id { get; set; }
        public long BankAccountId { get; set; }
        public DateTime Created { get; set; }
        public DateTime FromDate { get; set; }
        public long HouseId { get; set; }
        public DateTime? ToDate { get; set; }
        public string BankAccountBik { get; set; }
        public long BankAccountOwnerId { get; set; }
        public string BankAccountOwnerName { get; set; }
        public decimal? BankAccountNumber { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public int? BankAccountPropertyId { get; set; }
        public string BankAccountPropertyIname { get; set; }
    }
}
