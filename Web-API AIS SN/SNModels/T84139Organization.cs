using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class T84139Organization
    {
        public long Id { get; set; }
        public int Code { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string Ogrn { get; set; }
        public long? ParentId { get; set; }
        public bool IsServiceProvider { get; set; }
        public bool IsHouseHolder { get; set; }
        public bool IsCashlessTransferrer { get; set; }
        public bool IsBenefitTransferrer { get; set; }
        public bool IsFlatOwner { get; set; }
        public DateTime Datec { get; set; }
        public DateTime Dateb { get; set; }
        public DateTime? Datee { get; set; }
        public string Info { get; set; }
        public string AddrInfo { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Manager { get; set; }
        public string ManagerPosition { get; set; }
        public string AddrName { get; set; }
        public bool IsBankrupt { get; set; }
        public string TelephoneEmergencyDispatchService { get; set; }
        public bool IsPaymentAgent { get; set; }
        public bool IsResourceProvider { get; set; }
        public bool IsContractEnded { get; set; }
        public string ModeWork { get; set; }
        public bool? IsBankPaymentAgent { get; set; }
        public string ChiefAccountant { get; set; }
        public int? DistributionPayment { get; set; }
        public bool? IsPaymentUseNotice { get; set; }
        public bool? IsPaymentUseNegativeSumm { get; set; }
        public bool IsFinancialCenter { get; set; }
        public string NoticeInformation { get; set; }
        public bool NoticeInformationWithAddressesInfo { get; set; }
        public bool NoticeInformationOnlyAddressesInfo { get; set; }
        public DateTime? FromDateOfAccrualPenalties { get; set; }
        public string ReportsSignature { get; set; }
        public string AddrInternetInfo { get; set; }
        public string Kbk { get; set; }
        public string Oktmo { get; set; }
        public bool IsUnitOrganization { get; set; }
        public bool IsGeneralContractor { get; set; }
        public int? OrgLegalForm { get; set; }
        public int? OrgType { get; set; }
        public DateTime? OrgRegistrationDate { get; set; }
        public string KodObj { get; set; }
        public string Ogrnip { get; set; }
        public long? JuridicAdrId { get; set; }
        public long? FactAdrId { get; set; }
        public long? MailAdrId { get; set; }
        public int? OkvedType { get; set; }
        public int? BudgetType { get; set; }
        public int? FkkoType { get; set; }
        public int? OrganizationType { get; set; }
        public int? ConsumersType { get; set; }
        public int? PurchaseMethod { get; set; }
        public int? TkoType { get; set; }
        public long? DepartmentId { get; set; }
        public string Email { get; set; }
        public long? OrpKey { get; set; }
        public bool IsTerritorialManage { get; set; }
    }
}
