using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T80213Account
    {
        public long Id { get; set; }
        public long ApartmentId { get; set; }
        public string Number { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public DateTime Datec { get; set; }
        public long? KodCl { get; set; }
        public long? KodObj { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public bool? NeedOwnerPresence { get; set; }
        public string Comment { get; set; }
        public bool NeedPrintNotice { get; set; }
        public string IdentityCardNumber { get; set; }
        public string IdentityCardHolderName { get; set; }
        public string DocInfo { get; set; }
        public long? NoticeAdrId { get; set; }
        public int? UseAccountServiceGroups { get; set; }
        public string NoticeAdrName { get; set; }
        public bool? IsCloseInPaymentSystem { get; set; }
        public bool? IsArchived { get; set; }
        public long? AdministrationDistrictId { get; set; }
        public string NoticeEmail { get; set; }
        public int? TypeBudget { get; set; }
        public bool NeedEmailNotice { get; set; }
        public DateTime? DateComment { get; set; }
        public string NoticeAdrPostalIndex { get; set; }
        public bool NeedOnlyEmailNotice { get; set; }
        public bool SetCounterIndicationWoauth { get; set; }
        public bool NeedSendAndPrintNotice { get; set; }
    }
}
