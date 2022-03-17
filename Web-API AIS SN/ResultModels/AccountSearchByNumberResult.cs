using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountSearchByNumberResult
    {
		public string AccountNumber { get; set; }

		public string FullAddress { get; set; }

		public string Owner { get; set; }

		public string FiasHouse { get; set; }

		public string FiasRoom { get; set; }

		public string Room { get; set; }

		public string House { get; set; }

		public string Street { get; set; }

		public string City { get; set; }

		public System.Nullable<bool> IsClose { get; set; }

		public System.Nullable<long> ApartmentId { get; set; }

		public string TerritorialSubDivisionName { get; set; }

		public string TerritorialSubDivisionCode { get; set; }

		public System.Nullable<bool> AnyCounters { get; set; }

		public System.Nullable<bool> IndicationAVG { get; set; }

		public System.Nullable<long> AccountId { get; set; }

		public string ELS { get; set; }

		public string DateCreated { get; set; }

		public string PSK { get; set; }


	}
}
