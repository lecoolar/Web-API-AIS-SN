using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountInformsView
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public long? DebtActionId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Period { get; set; }
        public decimal? Summ { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public string Telephone { get; set; }
        public string Comment { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string NameEmployee { get; set; }
        public string ContactFio { get; set; }
        public int? CallResultId { get; set; }
        public string CallResultName { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? DateB { get; set; }
        public DateTime? DateE { get; set; }
        public long? HouseHolderId { get; set; }
        public int? HouseHolderCode { get; set; }
        public string HouseHolderShortName { get; set; }
    }
}
