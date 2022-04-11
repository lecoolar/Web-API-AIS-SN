using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GetLocalAddressResult
    {
		public long Id { get; set; }

		public string Name { get; set; }

		public string Socr { get; set; }

		public string FiasCode { get; set; }
	}
}
