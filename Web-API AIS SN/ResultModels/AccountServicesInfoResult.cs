using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountServicesInfoResult
    {
        public long? Id { get; set; }

        public long? AccountId { get; set; }

        public string AccountNumber { get; set; }

        public long? ServiceId { get; set; }

        public string ServiceShortName { get; set; }

        public string ServiceFromDate { get; set; }

        public string ServiceTypeName { get; set; }

        public long? ServiceTypeParentId { get; set; }

        public string ServiceNormRate { get; set; }

        public string OrgName { get; set; }

        public string AlgorithmName { get; set; }

        public string CurrentRate { get; set; }

        public string LastRate { get; set; }

        public string HouseHolderShortName { get; set; }

        public string ResourceProviderShortName { get; set; }

        public string GeneralContractorShortName { get; set; }

        public string ExecutorGisName { get; set; }

        public string ApartmentAddrName { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string Created { get; set; }

        public string Balance { get; set; }

        public string BalancePeni { get; set; }

        public string ServiceTypeGroupName { get; set; }

        public string OpenDocOrgName { get; set; }

        public string CloseDocOrgName { get; set; }

        public long? ProviderId { get; set; }

        public string ServiceApartmentTypeName { get; set; }

        public string UnitName { get; set; }

        public bool? IsBankrupt { get; set; }
    }
}
