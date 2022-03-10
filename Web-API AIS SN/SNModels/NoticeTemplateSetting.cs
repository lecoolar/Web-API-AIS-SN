using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateSetting
    {
        public NoticeTemplateSetting()
        {
            Actions = new HashSet<Action>();
            NoticeTemplateSettingBlocks = new HashSet<NoticeTemplateSettingBlock>();
            NoticeTemplateSettingParameters = new HashSet<NoticeTemplateSettingParameter>();
            NoticeTemplateSettingProviders = new HashSet<NoticeTemplateSettingProvider>();
            NoticeTemplateSettingReplaceRicOrgs = new HashSet<NoticeTemplateSettingReplaceRicOrg>();
            NoticeTemplateSettingRightOrganizations = new HashSet<NoticeTemplateSettingRightOrganization>();
            ResultAccountNotices = new HashSet<ResultAccountNotice>();
            ResultNotices = new HashSet<ResultNotice>();
        }

        public long Id { get; set; }
        public long NoticeTemplateId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public bool IsLkActive { get; set; }
        public bool AutoRendering { get; set; }
        public bool IsOpenByAccountDates { get; set; }
        public bool IsOpenByServiceDatesOrExistChargeSumm { get; set; }
        public bool IsOpenByServiceDatesOrExistChargeSummOrExistToPaySumm { get; set; }
        public bool IsExistChargeSummOrExistToPaySumm { get; set; }
        public bool? IsOpenByServiceDatesOrExistAnySumm { get; set; }
        public bool IsExistBeginDebit { get; set; }
        public bool IsExistBeginCredit { get; set; }
        public bool ShowNoticeInformation { get; set; }
        public bool ExcludeServiceOldHouseHolder { get; set; }
        public bool ExcludeServiceProviderBankrupt { get; set; }
        public long? ForceHouseHolderId { get; set; }
        public bool NotReadRenderedNotices { get; set; }
        public string SubSettingGroup { get; set; }
        public bool IsExistEndDebit { get; set; }
        public bool ExcludeServiceExistBeginCredit { get; set; }
        public bool ExcludeServiceExistBeginDebit { get; set; }
        public bool ExcludeServiceExistBeginCreditSaldo { get; set; }
        public bool ExcludeServiceExistEndCredit { get; set; }
        public bool ShowRecalcByPeriod { get; set; }
        public long? ForceRicOrgId { get; set; }
        public long? SubProviderId { get; set; }
        public bool? HideServiceWithoutChargeSumm { get; set; }
        public bool OnlyNonResidential { get; set; }
        public int? ApartmentType { get; set; }
        public int? AccountParam { get; set; }
        public int? AccountParam2 { get; set; }
        public bool? HouseBankAccountPrimary { get; set; }
        public bool ApartmentTypeRevert { get; set; }
        public bool AccountParamRevert { get; set; }
        public bool AccountParamRevert2 { get; set; }
        public bool IsOpenByServiceDates { get; set; }
        public bool IsExistChargeSumm { get; set; }
        public bool ShowLinesRecalcDetalic { get; set; }
        public bool UseChargeAsToPaySumm { get; set; }
        public bool IsServiceFinancialCenterEqual { get; set; }
        public int? ExcludeServiceApartmentTypeId { get; set; }
        public string PdfExportParametersPacked { get; set; }
        public int? Sort { get; set; }
        public bool IsExistChargeSummOrExistRecalcSumm { get; set; }

        public virtual NoticeTemplate NoticeTemplate { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<NoticeTemplateSettingBlock> NoticeTemplateSettingBlocks { get; set; }
        public virtual ICollection<NoticeTemplateSettingParameter> NoticeTemplateSettingParameters { get; set; }
        public virtual ICollection<NoticeTemplateSettingProvider> NoticeTemplateSettingProviders { get; set; }
        public virtual ICollection<NoticeTemplateSettingReplaceRicOrg> NoticeTemplateSettingReplaceRicOrgs { get; set; }
        public virtual ICollection<NoticeTemplateSettingRightOrganization> NoticeTemplateSettingRightOrganizations { get; set; }
        public virtual ICollection<ResultAccountNotice> ResultAccountNotices { get; set; }
        public virtual ICollection<ResultNotice> ResultNotices { get; set; }
    }
}
