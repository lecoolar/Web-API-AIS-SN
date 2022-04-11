using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class GetLocalAddressByFIOResult
    {
		public string LName { get; set; }

		public string FName { get; set; }

		public string MName { get; set; }

		public long? ApartmentId { get; set; }

		public long? AdrId { get; set; }
	}
}
