using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplateSettingsView
    {
        public long Id { get; set; }
        public long NoticeTemplateId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public string TemplateIdentityName { get; set; }
        public string TemplateName { get; set; }
        public string TemplateSql { get; set; }
        public int? PageCount { get; set; }
        public int? AccountsInTemplate { get; set; }
        public bool TemplateIsActive { get; set; }
        public bool IsActive { get; set; }
        public bool AutoRendering { get; set; }
        public bool IsOpenByAccountDates { get; set; }
        public bool IsOpenByServiceDates { get; set; }
        public bool IsOpenByServiceDatesOrExistChargeSumm { get; set; }
        public bool IsOpenByServiceDatesOrExistChargeSummOrExistToPaySumm { get; set; }
        public bool IsExistChargeSumm { get; set; }
        public bool IsExistChargeSummOrExistToPaySumm { get; set; }
        public bool IsOpenByServiceDatesOrExistAnySumm { get; set; }
        public bool IsExistBeginDebit { get; set; }
        public bool IsExistBeginCredit { get; set; }
        public bool ShowNoticeInformation { get; set; }
        public bool ExcludeServiceOldHouseHolder { get; set; }
        public bool ExcludeServiceProviderBankrupt { get; set; }
        public long? ForceHouseHolderId { get; set; }
        public bool IsLkActive { get; set; }
        public string SubSettingGroup { get; set; }
        public bool IsExistEndDebit { get; set; }
        public bool ExcludeServiceExistBeginCredit { get; set; }
        public bool ExcludeServiceExistBeginDebit { get; set; }
        public bool ExcludeServiceExistBeginCreditSaldo { get; set; }
        public bool ExcludeServiceExistEndCredit { get; set; }
        public bool ShowRecalcByPeriod { get; set; }
        public long? ForceRicOrgId { get; set; }
        public long? SubProviderId { get; set; }
        public int? ApartmentType { get; set; }
        public int? AccountParam { get; set; }
        public int? AccountParam2 { get; set; }
        public bool? HouseBankAccountPrimary { get; set; }
        public bool ApartmentTypeRevert { get; set; }
        public bool AccountParamRevert { get; set; }
        public bool AccountParamRevert2 { get; set; }
        public bool UseChargeAsToPaySumm { get; set; }
        public bool IsServiceFinancialCenterEqual { get; set; }
        public int? ExcludeServiceApartmentTypeId { get; set; }
        public string PdfExportParametersPacked { get; set; }
        public int? Sort { get; set; }
        public bool IsExistChargeSummOrExistRecalcSumm { get; set; }
        public bool NotReadRenderedNotices { get; set; }
        public bool? HideServiceWithoutChargeSumm { get; set; }
    }
}
