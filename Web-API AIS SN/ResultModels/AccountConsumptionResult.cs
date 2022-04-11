using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountConsumptionResult
    {
		public System.Nullable<long> ServiceId{ get; set; }

		public string ServiceName{ get; set; }

		public string RangeStart{ get; set; }

		public string RangeEnd{ get; set; }

		public string UiFormula{ get; set; }

		public string ChargeSumm{ get; set; }

		public System.Nullable<long> ProviderId{ get; set; }
	}
}
