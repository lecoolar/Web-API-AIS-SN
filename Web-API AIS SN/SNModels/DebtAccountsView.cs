using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtAccountsView
    {
        public long Id { get; set; }
        public long DebtDocumentId { get; set; }
        public long AccountId { get; set; }
        public decimal? DebtSumm { get; set; }
        public string AccountNumber { get; set; }
        public string AccountOwnerName { get; set; }
        public string AddressName { get; set; }
        public long AdrId { get; set; }
        public int? MonthCount { get; set; }
        public long ApartmentId { get; set; }
        public int? StatusTypeName { get; set; }
        public int? StatusActionName { get; set; }
        public int? StatusNotices { get; set; }
        public int? PaidSumm { get; set; }
        public int? SummAction { get; set; }
        public decimal? Gosposhlina { get; set; }
        public decimal? Peny { get; set; }
        public int WithHistory { get; set; }
        public int? TypeIdAnomaly { get; set; }
        public string AnomalyName { get; set; }
        public long? ScanDocId { get; set; }
        public DateTime? DateAnomaly { get; set; }
        public int? TypeStatusByNotice { get; set; }
        public string StatusByNoticeName { get; set; }
        public int? NoticeCreated { get; set; }
        public string Comment { get; set; }
        public int? DateLastChange { get; set; }
        public int? UserId { get; set; }
        public int? UserName { get; set; }
        public DateTime? DebtFromDate { get; set; }
        public DateTime? DebtToDate { get; set; }
        public decimal? RepresentationExpenses { get; set; }
        public long? ApartmentOwnerId { get; set; }
        public string ApartmentOwnerName { get; set; }
        public int? DebtRank { get; set; }
        public int? TypeOwnerId { get; set; }
    }
}
