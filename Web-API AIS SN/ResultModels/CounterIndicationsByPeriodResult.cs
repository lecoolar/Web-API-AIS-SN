using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class CounterIndicationsByPeriodResult
    {
		public System.Nullable<long> Id{ get; set; }

		public System.Nullable<long> CounterId{ get; set; }

		public string Val{ get; set; }

		public string PrevVal{ get; set; }

		public string ValType{ get; set; }

		public string ValTypeName{ get; set; }

		public string ValDate{ get; set; }

		public string PrevValDate{ get; set; }

		public string Created{ get; set; }

		public System.Nullable<long> GroupOperId{ get; set; }

		public string Comment{ get; set; }

		public string CounterTypeName{ get; set; }

		public string CounterName{ get; set; }

		public string CounterFromDate{ get; set; }

		public string CounterToDate{ get; set; }

		public System.Nullable<long> UserId{ get; set; }

		public string UserName{ get; set; }

		public string Consumption{ get; set; }

		public string MethodValInsertName{ get; set; }
	}
}
