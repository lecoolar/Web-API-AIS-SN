using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class AccountDebtorsInfoForRiasview
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime Created { get; set; }
        public long PersonId { get; set; }
        public string PersonLastName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonMiddleName { get; set; }
        public string Snils { get; set; }
        public string TypeDocument { get; set; }
        public string SerialDoc { get; set; }
        public string NumberDoc { get; set; }
        public long OrganizationId { get; set; }
        public int? OrganizationCode { get; set; }
        public string OrganizationName { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? RedemptionDate { get; set; }
        public bool? IsActive { get; set; }
        public decimal? FullDebtSumm { get; set; }
        public decimal? DebtSumm { get; set; }
        public decimal? PenySumm { get; set; }
        public decimal? GosposhlinaSumm { get; set; }
        public decimal? JudgeSumm { get; set; }
        public int? MonthCount { get; set; }
        public string Comment { get; set; }
        public bool? IsDebtAction { get; set; }
        public string CourtProcessNumber { get; set; }
    }
}
