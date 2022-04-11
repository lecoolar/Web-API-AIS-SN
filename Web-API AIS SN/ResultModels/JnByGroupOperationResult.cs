using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class JnByGroupOperationResult
    {
		public System.Nullable<long> Id{ get; set; }

		public System.Nullable<long> ProviderId{ get; set; }

		public System.Nullable<long> ProviderCode{ get; set; }

		public string ProviderName{ get; set; }

		public System.Nullable<long> ServiceTypeId{ get; set; }

		public string ServiceTypeName{ get; set; }

		public System.Nullable<long> ServiceId{ get; set; }

		public System.Nullable<long> ServiceCode{ get; set; }

		public string ServiceName{ get; set; }

		public string ServiceCodeName{ get; set; }

		public System.Nullable<long> AccountServiceId{ get; set; }

		public string AccountServiceFromDate{ get; set; }

		public string AccountServiceToDate{ get; set; }

		public System.Nullable<long> AccountId{ get; set; }

		public string AccountNumber{ get; set; }

		public System.Nullable<long> AccountOwnerId{ get; set; }

		public string AccountOwnerName{ get; set; }

		public System.Nullable<long> ApartmentId{ get; set; }

		public string ApartmentNumber{ get; set; }

		public System.Nullable<long> ApartmentAddrId{ get; set; }

		public string ApartmentAddrLevel{ get; set; }

		public string ApartmentAddrName{ get; set; }

		public System.Nullable<long> ApartmentParentAddrId{ get; set; }

		public System.Nullable<long> HouseHolderId{ get; set; }

		public string HouseHolderCode{ get; set; }

		public string HouseHolderName{ get; set; }

		public string FinancialCenterName{ get; set; }

		public string CalcOperId{ get; set; }

		public string CalcOperName{ get; set; }

		public string Created{ get; set; }

		public string Period{ get; set; }

		public string Summ{ get; set; }

		public string OriginalSumm{ get; set; }

		public System.Nullable<long> GroupOperId{ get; set; }

		public System.Nullable<long> Old_id{ get; set; }

		public System.Nullable<long> UserId{ get; set; }

		public string UserName{ get; set; }

		public string Bankrupt{ get; set; }

		public string FixedPayment{ get; set; }

		public System.Nullable<long> RemitteePaymentOrderId{ get; set; }

		public System.Nullable<long> BankPaymentOrderRecordInputId{ get; set; }

		public string IsTransferPaymentRestriction{ get; set; }

		public string IsUnloadedProvider{ get; set; }
	}
}
