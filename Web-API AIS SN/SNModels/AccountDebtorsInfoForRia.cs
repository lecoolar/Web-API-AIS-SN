using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDebtorsInfoForRia
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public DateTime Created { get; set; }
        public long PersonId { get; set; }
        public long OrganizationId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? RedemptionDate { get; set; }
        public bool? IsActive { get; set; }
        public decimal? FullDebtSumm { get; set; }
        public decimal? DebtSumm { get; set; }
        public decimal? GosposhlinaSumm { get; set; }
        public decimal? JudgeSumm { get; set; }
        public int? MonthCount { get; set; }
        public decimal? PenySumm { get; set; }
        public string Comment { get; set; }
        public string CourtProcessNumber { get; set; }

        public virtual Organization1 Organization { get; set; }
        public virtual Person Person { get; set; }
        public virtual FasetItem Status { get; set; }
    }
}
