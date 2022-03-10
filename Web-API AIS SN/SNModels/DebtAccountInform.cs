using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountInform
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public int TypeId { get; set; }
        public long? DebtActionId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Period { get; set; }
        public decimal? Summ { get; set; }
        public int? StatusId { get; set; }
        public string Telephone { get; set; }
        public string Comment { get; set; }
        public long? UserId { get; set; }
        public string ContactFio { get; set; }
        public int? CallResult { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string NameEmployee { get; set; }
        public DateTime? DateB { get; set; }
        public DateTime? DateE { get; set; }
        public long? HouseHolderId { get; set; }

        public virtual Organization1 HouseHolder { get; set; }
        public virtual FasetItem Status { get; set; }
        public virtual FasetItem Type { get; set; }
    }
}
