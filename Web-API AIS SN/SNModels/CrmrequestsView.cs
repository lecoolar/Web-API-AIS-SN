using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class CrmrequestsView
    {
        public long Id { get; set; }
        public DateTime? Created { get; set; }
        public long? MapId { get; set; }
        public long? StepId { get; set; }
        public long? AccountId { get; set; }
        public byte Status { get; set; }
        public int? XmlIn { get; set; }
        public string Comment { get; set; }
        public long? GroupOperId { get; set; }
        public byte? RequestTypeId { get; set; }
        public long? AddrId { get; set; }
        public string AddrName { get; set; }
        public string StatusName { get; set; }
        public string RequestTypesName { get; set; }
        public int? StatusId { get; set; }
        public string FasetItemStatusName { get; set; }
        public string CrmJsonAccount { get; set; }
        public string CrmJsonRequestType { get; set; }
        public string CrmJsonText { get; set; }
        public string CrmJsonRequestId { get; set; }
        public DateTime? ReplyDate { get; set; }
        public string CrmJsonApplicantName { get; set; }
        public string CrmJsonApplicantPhoneNumber { get; set; }
        public string CrmJsonApplicantEmail { get; set; }
        public string CrmJsonTicketReasonName { get; set; }
        public string CompletedWork { get; set; }
        public byte[] Attachments { get; set; }
        public string CrmJsonApplicantComment { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public int? CrmJsonApplicantNote { get; set; }
        public string CrmJsonOperatorComment { get; set; }
        public string TerritorialSubdivisionOrganizationName { get; set; }
        public int? TerritorialSubdivisionOrganizationCode { get; set; }
    }
}
