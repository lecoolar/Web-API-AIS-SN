using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class HouseTreatyCommitment
    {
        public long Id { get; set; }
        public DateTime Period { get; set; }
        public DateTime Created { get; set; }
        public long HouseId { get; set; }
        public long? ServiceId { get; set; }
        public decimal CostsExecutor { get; set; }
        public long? ServiceTypeId { get; set; }
        public long? HouseHolderId { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? Charge { get; set; }
        public decimal? ChargeAccounts { get; set; }
        public decimal? RecalcAccounts { get; set; }
        public decimal? Delta { get; set; }
        public decimal? PaymentAccounts { get; set; }
        public decimal? ChargeAccountsNotLiving { get; set; }
        public decimal? PaymentAccountsNotLiving { get; set; }
        public decimal? RecalcAccountsNotLiving { get; set; }
        public decimal? ChargeNotLiving { get; set; }

        public virtual House House { get; set; }
        public virtual Organization1 HouseHolder { get; set; }
        public virtual Service1 Service { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
