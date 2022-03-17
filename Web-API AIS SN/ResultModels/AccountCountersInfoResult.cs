using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class AccountCountersInfoResult
    {
		public long? Id{ get; set; }

		public string CounterName{ get; set; }

		public string CounterTypeName{ get; set; }

		public string CounterNumber{ get; set; }

		public string TypeScaleCounterName{ get; set; }

		public string ServiceTypeName{ get; set; }

		public string Val{ get; set; }

		public string ValDate{ get; set; }

		public string Size{ get; set; }

		public string StartDate{ get; set; }

		public string EndDate{ get; set; }

		public string ValTypeId{ get; set; }

		public string ValTypeName{ get; set; }

		public string ProviderName{ get; set; }

		public long? ProviderId{ get; set; }

		public string CounterServiceToDate{ get; set; }

		public bool? CounterIsCommunal{ get; set; }

		public bool? IsRemotelyRemoteIndications{ get; set; }

		public string LastCheckIntervalFromDate{ get; set; }

		public string LastCheckIntervalToDate{ get; set; }

		public string CounterNumberAISMeter{ get; set; }
	}
}
