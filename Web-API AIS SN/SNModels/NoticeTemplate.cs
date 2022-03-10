using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class NoticeTemplate
    {
        public NoticeTemplate()
        {
            NoticeTemplateProviders = new HashSet<NoticeTemplateProvider>();
            NoticeTemplateSettings = new HashSet<NoticeTemplateSetting>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Sql { get; set; }
        public string IdentityName { get; set; }
        public bool? IsActive { get; set; }
        public string Template { get; set; }
        public int? AccountsInTemplate { get; set; }
        public int? PageCount { get; set; }
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
        public int? Version { get; set; }
        public long? ForceHouseHolderId { get; set; }
        public bool? IsLkActive { get; set; }
        public int? Sort { get; set; }
        public bool DisableGenerate { get; set; }

        public virtual ICollection<NoticeTemplateProvider> NoticeTemplateProviders { get; set; }
        public virtual ICollection<NoticeTemplateSetting> NoticeTemplateSettings { get; set; }
    }
}
