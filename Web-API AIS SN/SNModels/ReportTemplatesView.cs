using System;
using System.Collections.Generic;

#nullable disable

namespace Web_API_AIS_SN.SNModels
{
    public partial class ReportTemplatesView
    {
        public long Id { get; set; }
        public long ReportGroupId { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public string Sql { get; set; }
        public bool? OrgsHouseHolders { get; set; }
        public bool? OrgsServiceHouseHolders { get; set; }
        public bool? OrgsCashlessTransferrers { get; set; }
        public bool? OrgsServiceProviders { get; set; }
        public bool? OrgsResourceProviders { get; set; }
        public bool? ServiceTypes { get; set; }
        public bool? Services { get; set; }
        public bool? ApartmentTypes { get; set; }
        public bool? Addresses { get; set; }
        public bool? Benefits { get; set; }
        public bool? Debt { get; set; }
        public bool? ExistsBenefitDiff { get; set; }
        public bool? CanonicalServices { get; set; }
        public bool? ConvenienceTypes { get; set; }
        public bool IsSimpleTable { get; set; }
        public bool IsTxt { get; set; }
        public bool? CalcOperationGroups { get; set; }
        public bool? DatePeriod { get; set; }
        public bool? MinSumm { get; set; }
        public bool? PaymentAgentTypes { get; set; }
        public bool? Terminals { get; set; }
        public bool? TypeRecalcReasons { get; set; }
        public bool? IsExcel { get; set; }
        public bool? IsAppending { get; set; }
        public bool IsEnable { get; set; }
        public bool? IsAvailableInProvider { get; set; }
        public bool WithoutClosesApartments { get; set; }
        public bool WithoutBankrupt { get; set; }
        public bool? OrgsBank { get; set; }
        public bool? AccountProperty { get; set; }
        public bool OrgsPaymentAgents { get; set; }
        public short? FasetFilterId { get; set; }
        public string FasetFilterName { get; set; }
        public bool? OrgsApartmentArea { get; set; }
        public bool? HouseTypes { get; set; }
        public bool? CityBorough { get; set; }
        public string Location { get; set; }
        public string Number { get; set; }
        public bool Period { get; set; }
        public string TextParameter { get; set; }
        public bool WithRenderParameters { get; set; }
        public bool ReesterTypes { get; set; }
        public bool WithSave { get; set; }
        public string Organization { get; set; }
        public bool OrgsFinancialCenters { get; set; }
        public bool? OrganizationAccountOwner { get; set; }
        public bool? ServiceApartmentTypeFasetItemId { get; set; }
        public bool? AdministrationDistrict { get; set; }
        public bool BankAccounts { get; set; }
        public bool Users { get; set; }
        public string Encoding { get; set; }
        public bool? OrgDocument { get; set; }
        public bool IsGroupOperation { get; set; }
        public string Comment { get; set; }
        public bool IsCustomReport { get; set; }
        public string NetworkFilePath { get; set; }
        public bool RunInTransaction { get; set; }
    }
}
