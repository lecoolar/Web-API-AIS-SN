using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class DebtActionsView
    {
        public long Id { get; set; }
        public long DebtAffairId { get; set; }
        public long DebtAccountId { get; set; }
        public int StatusId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime Created { get; set; }
        public int? StatusTypeId { get; set; }
        public long DebtDocumentId { get; set; }
        public long AccountId { get; set; }
        public long ApartmentId { get; set; }
        public string AccountOwnerName { get; set; }
        public string AddressName { get; set; }
        public int? MonthCount { get; set; }
        public decimal? DebtSumm { get; set; }
        public string HouseHolderName { get; set; }
        public string OrgDocumentName { get; set; }
        public string StatusName { get; set; }
        public string StatusTypeName { get; set; }
        public string NameAction { get; set; }
        public string AccountNumber { get; set; }
        public decimal? Gosposhlina { get; set; }
        public string HouseType { get; set; }
        public string ApartmentType { get; set; }
        public string LastActionNoticesName { get; set; }
        public DateTime? LastActionNoticesDate { get; set; }
        public decimal? NachPenalty { get; set; }
        public DateTime? FromDateDebt { get; set; }
        public DateTime? ToDateDebt { get; set; }
        public string CourtProcessNumber { get; set; }
        public string ExecProcessNumber { get; set; }
        public long? StageId { get; set; }
        public string StageName { get; set; }
        public string DebtActionNumber { get; set; }
        public int? TypePirid { get; set; }
        public string TypePirname { get; set; }
        public int? TypeStageResult { get; set; }
        public string TypeStageResultName { get; set; }
        public DateTime? StatusChangeDate { get; set; }
        public DateTime? DebtFromDate { get; set; }
        public DateTime? DebtToDate { get; set; }
        public long? CreatedUserId { get; set; }
        public string CreatedUserName { get; set; }
        public long? ChangedUserId { get; set; }
        public string ChangedUserName { get; set; }
        public DateTime DdFromDate { get; set; }
        public string CommentAccount { get; set; }
    }
}
