using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_AIS_SN.ResultModels
{
    public class SeletReportsAndSettingResult
    {
		public long? ReportId { get; set; }

		public string ReportName { get; set; }

		public long? SettingId { get; set; }

		public string SettingName { get; set; }
	}
}
